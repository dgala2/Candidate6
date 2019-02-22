using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using CustomerManagement.Classes;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer=new Customer();

            List<CustomerModel> customers=new List<CustomerModel>();
            CustomerModel CustomerModel=new CustomerModel();
            CustomerModel.DateOfBirth =Convert.ToDateTime("06/12/2017");
            CustomerModel.CustomerGender = Gender.GenderEnum.Female;
            CustomerModel.CustomerId = 1;
            CustomerModel.CustomerName = "ABC";
            customers.Add(CustomerModel);

            CustomerModel CustomerModel1 = new CustomerModel();
            CustomerModel1.DateOfBirth = Convert.ToDateTime("06/01/1986");
            CustomerModel1.CustomerGender = Gender.GenderEnum.Female;
            CustomerModel1.CustomerId = 2;
            CustomerModel1.CustomerName = "ABC";

            CustomerModel CustomerModel2 = new CustomerModel();
            CustomerModel2.DateOfBirth = Convert.ToDateTime("20/12/1987");
            CustomerModel2.CustomerGender = Gender.GenderEnum.Male;
            CustomerModel2.CustomerId = 3;
            CustomerModel2.CustomerName = "ABC";

            customers.Add(CustomerModel1);
            customers.Add(CustomerModel2);

            var ages = customer.CalculateAge(customers);
            var agesMale = customer.CalculateAge(customers.Where(i=>i.CustomerGender==Gender.GenderEnum.Male).ToList());
            var agesFemale = customer.CalculateAge(customers.Where(i => i.CustomerGender == Gender.GenderEnum.Female).ToList());

            var avgages = customer.CalculateAverage(ages);
            var averageMale = customer.CalculateAverage(agesMale);
            var averageFemale = customer.CalculateAverage(agesFemale);
            

        }
    }
}
