using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.DataLayer.Services;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TypeEntity> where TypeEntity : class
    {
        private Accounting_DBEntities _DB;
        private DbSet<TypeEntity> _DBSet;
        public GenericRepository(Accounting_DBEntities DB)
        {
            _DB = DB;
            _DBSet = DB.Set<TypeEntity>();
        }
        public virtual IEnumerable<TypeEntity> Get(Expression<Func<TypeEntity,bool>> where=null)
        {
            IQueryable<TypeEntity> Query = _DBSet;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            return Query.ToList();
        }
        public virtual TypeEntity GetById(object Id)
        {
            return _DBSet.Find(Id);
        }
        public void Insert(TypeEntity entity)
        {
            _DBSet.Add(entity);
        }
        public virtual void Update(TypeEntity entity)
        {
            if (_DB.Entry(entity).State == EntityState.Detached)
            {
                _DBSet.Attach(entity);
            }
            _DB.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TypeEntity entity)
        {
            if (_DB.Entry(entity).State == EntityState.Detached)
            {
                _DBSet.Attach(entity);
            }
            _DBSet.Remove(entity);
        }
        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
}
