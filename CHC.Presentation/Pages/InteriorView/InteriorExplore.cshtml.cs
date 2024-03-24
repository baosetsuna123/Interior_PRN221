using CHC.Application.Service;
using CHC.Domain.Dtos.Interior;
using CHC.Domain.Entities;
using CHC.Domain.Pagination;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;

namespace CHC.Presentation.Pages.InteriorView
{
    public class InteriorExploreModel : PageModel
    {
        private readonly IInteriorService interiorService;

        public InteriorExploreModel(IInteriorService interiorService)
        {
            this.interiorService = interiorService;
        }

        [BindProperty(SupportsGet = true)]
        public IList<InteriorDto> Interiors { get; set; } = default!;


        public int PageIndex { get; set; } = 1;
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 10;
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
        public string? SearchString { get; set; } = string.Empty;


        public async Task<IActionResult> OnGetAsync(string? searchString, int? pageIndex, int? size)
        {
            if (pageIndex is not null) PageIndex = pageIndex.Value;
            if (size is not null) PageSize = size.Value;
            if (searchString is null)
                SearchString = string.Empty;
            Expression<Func<Interior, bool>> predicate = string.IsNullOrEmpty(searchString)
                                                            ? x => true
                                                            : x => x.Name.Contains(searchString);
            IPaginate<InteriorDto> interiors = await interiorService.GetPagination(predicate, PageIndex, PageSize);

            Interiors = interiors.Items;
            TotalPages = interiors.TotalPages;
            return Page();
        }

        public async Task<IActionResult> OnPostSearchAsync(string? search = "")
        {
            Expression<Func<Interior, bool>> predicate = string.IsNullOrEmpty(search)
                                                            ? x => true
                                                            : x => x.Name.Contains(search);
            IPaginate<InteriorDto> interiors = await interiorService.GetPagination(predicate, PageIndex, PageSize);
            Interiors = interiors.Items;
            TotalPages = interiors.TotalPages;
            return Page();
        }
    }
}
