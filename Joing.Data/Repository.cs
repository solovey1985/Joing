using System;
using Joing.Data;
using Joing.Infra;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using Joing.Infra.Guard;
using Joing.Infra.Data;
using System.Linq;

namespace Joing.Data
{
    public abstract class Repository<T, TContext> : IRepository<T> where T : Entity where TContext : DbContext
    {
        public IContext<T> Dal { get; set; }
        private readonly IUnitOfWork<TContext> _unitOfWork;
        protected IDbSet<T> _dbSet => _context.Set<T>();
        private readonly DbContext _context;

        public Repository() { }

        public Repository(IUnitOfWork<TContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _context = unitOfWork.Context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public virtual T GetById(Guid id)
        {
            return _dbSet.FirstOrDefault(entity => entity.Id == id);
        }

        public virtual bool Insert(T entity)
        {
            entity.DbState = DbStateEnum.Added;
            _dbSet.Add(entity);
            return CommitChanges();
        }

        public virtual bool Update(T entity)
        {
            entity.DbState = DbStateEnum.Modified;
            _dbSet.Attach(entity);
            return CommitChanges();
        }

        public bool Delete(T entity)
        {
            entity.DbState = DbStateEnum.Deleted;
            _dbSet.Remove(entity);
            return CommitChanges();
        }

        public virtual bool DeleteById(Guid id)
        {
            T entity = _dbSet.FirstOrDefault(e => e.Id == id);
            if (entity == null) throw new ObjectNotFoundException($"Entity with id = {id} not found.");
            entity.DbState = DbStateEnum.Deleted;
            _dbSet.Remove(entity);

            return CommitChanges();
        }

        private bool CommitChanges()
        {
            return _unitOfWork.Save();
        }
    }
}
