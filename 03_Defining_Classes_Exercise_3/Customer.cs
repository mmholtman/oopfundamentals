using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_3
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int YearsWithKomodo { get; set; }
        
        public Customer(Guid customerId, string lastName, int age, int yearsWithKomodo)
        {
            CustomerId = customerId;
            LastName = lastName;
            Age = age;
            YearsWithKomodo = yearsWithKomodo;
        }
    }

    public class CustomerRepo
    {
        private readonly List<Customer> _customerList;

        public CustomerRepo()
        {
            _customerList = new List<Customer>();
        }

        public List<Customer> AddCustomerToList(Customer customer)
        {
            _customerList.Add(customer);
            return _customerList;
        }

        public string SendThankYouNote(Customer customer)
        {
            var message = "";

            if (customer.YearsWithKomodo > 1 && customer.YearsWithKomodo < 5)
            {
                message = "Thanks for your support";
            }else if (customer.YearsWithKomodo > 5)
                message = "You're a gold member";

            return message;
        }

    }
}
