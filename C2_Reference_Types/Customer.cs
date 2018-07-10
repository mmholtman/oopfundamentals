using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Reference_Types
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public Customer(string name, string email, string number)
        {
            Name = name;
            Email = email;
            PhoneNumber = number;
        }

        public Customer()
        {
            
        }

        public Customer(Guid id, string lastName, string email, string number)
        {
            
        }

        public Customer CreateCustomer()
        {
            Customer customer = new Customer("", "", "")
            {
                Name = "Max",
                Email = "maxholtman1@gmail.com",
                PhoneNumber = "3172199322"
            };
            return customer;
        }

    }
}
