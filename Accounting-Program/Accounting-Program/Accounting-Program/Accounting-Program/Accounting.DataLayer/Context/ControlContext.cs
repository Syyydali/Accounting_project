using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;


namespace Accounting.DataLayer.Context
{
    public class ControlContext : IDisposable
    {
        Accounting_DBEntities DB = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
         get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(DB);
                }
                return _customerRepository;
            }
        }
        private GenericRepository<Accounting> _AccountingRepository;
        public GenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_AccountingRepository == null)
                {
                    _AccountingRepository = new GenericRepository<Accounting>(DB);
                }
                return _AccountingRepository;
            }
        }
        private GenericRepository<Login> _LoginRepository;
        public GenericRepository<Login> LoginRepository { get
            {
                if (_LoginRepository == null)
                {
                    _LoginRepository = new GenericRepository<Login>(DB);
                }
                return _LoginRepository;
            }
        }
        
        public void Save()
        {
          DB.SaveChanges();
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
