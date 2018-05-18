using MyShopOnline.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopOnline.Data.EF
{
    public class EFunitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EFunitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
