using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get ; set ; }
    }
}
