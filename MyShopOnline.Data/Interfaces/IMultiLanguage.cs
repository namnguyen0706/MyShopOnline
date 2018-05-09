using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguangeId { get; set; }
    }
}
