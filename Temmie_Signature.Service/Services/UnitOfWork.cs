using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temmie_Signature.Repo.Data.Context;
using Temmie_Signature.Repo.GenericRepository.Implementation;
using Temmie_Signature.Repo.GenericRepository.Interface;
using Temmie_Signature.Service.Interfaces;

namespace Temmie_Signature.Service.Services
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepo<T> _repository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IGenericRepo<T> Repository => _repository ??= new GenericRepo<T>(_context);

        public void BeginTransaction() => _context.Database.BeginTransaction();


        public void CommitTransaction() => _context.Database.CommitTransaction();


        public void RollbackTransaction() => _context.Database.RollbackTransaction();


        public async Task<bool> SaveAsync()
        {
            bool result = false;
            try
            {
                result = await _context.SaveChangesAsync() >= 0;
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }
    }
}

