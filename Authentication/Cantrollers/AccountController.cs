using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Cantrollers
{
    public  class AccountController
    {
        public void Login()
        {
            Console.WriteLine("add email");
            string email = Console.ReadLine();

            Console.WriteLine("add password");
            string password = Console.ReadLine();

            int roleId = 2;
            IAccountService account = new AccountServices();
            string result = account.Login(email, password, roleId);
            Console.WriteLine(result);
        }
    }
}
