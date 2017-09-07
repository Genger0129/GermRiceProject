using NFine.Code;
using NFine.Domain.IRepository.SystemManage;
using NFine.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace NFine.Application.SystemManage
{
    public class CommonApp<TEntity> where TEntity : class,new()
    {
        private ICommonRepository<TEntity> service = new CommonRepository<TEntity>();
        public int Insert(TEntity entity)
        {
            return service.Insert(entity);
        }

        public int Insert(List<TEntity> entitys)
        {
            return service.Insert(entitys);
        }
        public int Update(TEntity entity)
        {
            return service.Update(entity);
        }
        public int Delete(TEntity entity)
        {
            return service.Delete(entity);
        }
        public int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            return service.Delete(predicate);
        }
        public TEntity FindEntity(object keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public TEntity FindEntity(Expression<Func<TEntity, bool>> predicate)
        {
            return service.FindEntity(predicate);
        }
        public IQueryable<TEntity> IQueryable()
        {
            return service.IQueryable();
        }
        public IQueryable<TEntity> IQueryable(Expression<Func<TEntity, bool>> predicate)
        {
            return service.IQueryable(predicate);
        }
        public List<TEntity> FindList(string strSql)
        {
            return service.FindList(strSql);
        }
        public List<TEntity> FindList(string strSql, DbParameter[] dbParameter)
        {
            return service.FindList(strSql, dbParameter);
        }
        public List<TEntity> FindList(Pagination pagination)
        {
            return service.FindList(pagination);
        }
        public List<TEntity> FindList(Expression<Func<TEntity, bool>> predicate, Pagination pagination)
        {
            return service.FindList(predicate,pagination);
        }
    }
}
