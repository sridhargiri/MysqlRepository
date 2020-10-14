﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiDeploy.Model;

namespace WebapiDeploy.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        public int Add(Customer customer)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                return customer.CustomerID;
            }
            catch
            {

                throw;
            }
        }
        public IEnumerable<Customer> GetCustomers()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch
            {

                throw;
            }
        }

    }


}