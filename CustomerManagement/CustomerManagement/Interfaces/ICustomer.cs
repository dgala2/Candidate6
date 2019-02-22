using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement;

namespace CustomerManagement.Interfaces
{
    public interface ICustomer
    {
       double CalculateAverage(List<int> customers);
      

        List<int> CalculateAge(List<CustomerModel> customers);



    }
}
