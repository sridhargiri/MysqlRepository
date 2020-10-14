using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiDeploy.Model;

namespace WebapiDeploy.Repository
{
    public interface ICustomerRepository
    {
        int Add(Customer customer);
        IEnumerable<Customer> GetCustomers();
    }
}
