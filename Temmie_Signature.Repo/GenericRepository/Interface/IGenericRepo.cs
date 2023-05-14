using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Temmie_Signature.Repo.GenericRepository.Interface
{
    public interface IGenericRepo<T> where T : class
    {
        /// <summary>
        /// Add a new instance of an entity to the db
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task Add(T entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task AddRange(IList<T> entities);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IQueryable<T> ReadAllQuery();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> ReadAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EntityId"></param>
        /// <returns></returns>
        Task<T> ReadSingle(Guid EntityId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void UpdateRange(IList<T> entities);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EntityId"></param>
        /// <returns></returns>
        Task Delete(Guid EntityId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void DeleteRange(IList<T> entities);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    }
}
