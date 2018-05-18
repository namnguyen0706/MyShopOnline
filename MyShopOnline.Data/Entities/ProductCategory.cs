using MyShopOnline.Data.Enums;
using MyShopOnline.Data.Interfaces;
using MyShopOnline.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetadata, ISwitchable, ISortTable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeyWord { get; set; }
        public string SeoDescription { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public int SortOrder { get; set; }
    }
}
