using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Interfaces
{
    public interface IHasSeoMetadata
    {
        string SeoPageTitle { get; set; }

        string SeoAlias { get; set; }

        string SeoKeyWord { get; set; }

        string SeoDescription { get; set; }
    }
}
