using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temmie_Signature.Repo.GenericRepository.Interface;

namespace Temmie_Signature.Service.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        IGenericRepo<T> Repository { get; }
        Task<bool> SaveAsync();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

    }
}
