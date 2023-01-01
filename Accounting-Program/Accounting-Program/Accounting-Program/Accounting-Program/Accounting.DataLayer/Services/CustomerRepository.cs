using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using System.Data.Entity;
using Accounting.ViewModels.customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities datebase;

        public CustomerRepository(Accounting_DBEntities context)
        {
            datebase = context;
        }
       
        public List<Customers> GetAllCustomers()
        {
            return datebase.Customers.ToList();
        }
        public Customers GetCustomerByID(int customerID)
        {
            return datebase.Customers.Find(customerID);
        }
        public bool InsertCustomer(Customers customer)
        {
            try
            {
                datebase.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                datebase.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                datebase.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(int customerID)
        {
            try
            {
                var customer = GetCustomerByID(customerID);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return datebase.Customers.Where(c => c.FullName.Contains(parameter)||c.Email.Contains(parameter)||c.Mobile.Contains(parameter)).ToList();
        }
        public List<List_Customers_View_Model> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return datebase.Customers.Select(c => new List_Customers_View_Model() 
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,
                }).ToList();
            }
            return datebase.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new List_Customers_View_Model()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName,
            }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return datebase.Customers.First(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameByID(int customerId)
        {
            return datebase.Customers.Find(customerId).FullName;
        }
    }
}
