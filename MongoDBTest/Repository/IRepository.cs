using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBTest
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        WriteConcernResult Insert(TEntity entity);
        WriteConcernResult Update(TEntity entity);
        WriteConcernResult Delete(TEntity entity);
        IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> GetAll();
        TEntity GetById(string id);
    }
}
