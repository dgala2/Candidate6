using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CustomerManagement;



namespace CustomerManagement
{
    public class CustomerModel
    {
        
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
       
        public Gender.GenderEnum CustomerGender { get; set; }



    }

  
}
