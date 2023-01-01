using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.customers;

namespace Accounting.DataLayer.Repository
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<List_Customers_View_Model> GetNameCustomers(string filter = "");
        Customers GetCustomerByID(int customerID);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerID);
        int GetCustomerIdByName(string name);
        string GetCustomerNameByID(int customerId);
    }
}
