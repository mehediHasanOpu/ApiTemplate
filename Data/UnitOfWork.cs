using Core;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;

        }
        


        public int Commit() => _context.SaveChanges();
        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
