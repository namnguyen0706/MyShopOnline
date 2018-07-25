using MyShopOnline.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.Entities
{
    public class AdvertistmentPage : DomainEntity<string>
    {
        public string Name { get; set; }

        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}
