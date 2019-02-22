using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.Interfaces;

namespace CustomerManagement.Classes
{
   public class Customer:ICustomer
    {
        public List<int> CalculateAge(List<CustomerModel> customers)
        {
            DateTime todayDateTime = System.DateTime.Now;
            var ages = customers.Select(i => todayDateTime.Year- i.DateOfBirth.Year).ToList();
            return ages;
        }

        public double CalculateAverage(List<int> customers)
        {
            double averageAge = 0;
            DateTime todayDateTime = System.DateTime.Now;

            averageAge =customers.Average();





            return averageAge;
        }

       
    }
}
