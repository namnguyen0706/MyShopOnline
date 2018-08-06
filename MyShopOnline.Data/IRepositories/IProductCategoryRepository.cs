using MyShopOnline.Data.Entities;
using MyShopOnline.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace MyShopOnline.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}