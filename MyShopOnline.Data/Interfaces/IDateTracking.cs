﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }

        DateTime DateModified { get; set; }
    }
}
