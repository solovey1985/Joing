using Joing.Infra.Logger;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Infra.Data
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        bool Save();
        TContext Context { get; }

    }

    public abstract class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {

        public TContext Context => _context;
        private TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public bool Save()
        {
            Context.ApplyStateChanges();
            return Context.SaveChanges() > 0;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
