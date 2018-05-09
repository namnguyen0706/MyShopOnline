using MyShopOnline.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
