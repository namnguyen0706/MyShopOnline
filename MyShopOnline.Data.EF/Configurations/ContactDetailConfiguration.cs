﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyShopOnline.Data.EF.Extensions;
using MyShopOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
