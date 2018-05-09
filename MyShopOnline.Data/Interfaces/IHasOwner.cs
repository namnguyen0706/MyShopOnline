using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }

    }
}
