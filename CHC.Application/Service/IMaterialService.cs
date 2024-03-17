using CHC.Domain.Dtos.Material;
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
    public interface IMaterialService
    {
        public Task<List<MaterialDto>> GetAll();
        public Task<MaterialViewModel> GetOneByCondition(Expression<Func<Material, bool>> predicate);
    }
}
