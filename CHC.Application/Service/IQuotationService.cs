using CHC.Domain.Dtos.Quotation;
using CHC.Domain.Entities;
using CHC.Domain.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CHC.Application.Service
{
    public interface IQuotationService
    {
        Task<IPaginate<QuotationDto>> GetPagination(Expression<Func<Quotation, bool>> predicate, int page, int pageSize);
        Task<IList<QuotationDto>> GetAll(Expression<Func<Quotation, bool>> predicate);
        Task<QuotationDto> Get(Guid id);
        Task<QuotationDto> GetByCondition(Expression<Func<Quotation, bool>> predicate);
        Task<QuotationDto> Create(CreateQuotaionRequest createQuotaionRequest);
        Task<bool> Update(UpdateQuotationRequest updateQuotationRequest);
        Task<bool> Delete(Guid id);
    }
}
