using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Cantrollers
{
    public  class CustomerController
    {
        private readonly ICustomerservice _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }


        public void GetCustomerCountByFiltered()
        {
            Console.WriteLine(_service.GetCustomerCountByFiltered());

        }

        public void GetCustomerAverageByAges()
        {
            Console.WriteLine(_service.GetCustomerAverageByAges());
        }



    }
}
