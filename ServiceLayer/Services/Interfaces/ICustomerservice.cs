using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerservice
    {
        int GetCustomerCountByFiltered();
        double GetCustomerAverageByAges();
    }
}
