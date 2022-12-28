using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerservice
    {
        public double GetCustomerAverageByAges()
        {
            var customers = GetAll();

            int count = 0;
            foreach (var item in customers)
            {
                if (item.Age >25 && item.Age < 30)
                {
                    count++;
                } 


            }

            return count;

        }

        public int GetCustomerCountByFiltered()
        {
            var customer = GetAll();
            double sumAge = 0;

            foreach (var item in customer)
            {
                sumAge += item.Age;
            }


            return sumAge;


        }
        
        
        
        
        
        private CustomerService[] GetAll()
        {
            CustomerService c1 = new CustomerService
            { 
                Id =1,
                Name = "Shaiq",
                Surname= "Kazimov.",
                Age = 29,
                Position ="backend dovoloper"

            };



            CustomerService c3 = new CustomerService
            {
                Id = 2,
                Name = "Shaiq",
                Surname = "Kazimov.",
                Age = 27,
                Position = "frontend devoloper"


            };

            CustomerService c4 = new CustomerService
            {
                Id = 1,
                Name = "ali",
                Surname = "Kazimov.",
                Age = 24,
                Position = "fullstack devoloper"


            };
            CustomerService[] customers = {c1,c3,c4};
            return customers;
        }



        
    }




}
