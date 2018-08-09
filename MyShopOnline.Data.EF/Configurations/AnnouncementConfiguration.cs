using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopOnline.Data.EF.Extensions;
using MyShopOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.EF.Configurations
{
    public class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired();
            // etc.
        }
    }
}
