using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_1
{
    public class EncapCustomer
    {
        private string _firstName;
        private string _lastName;
        private int _age;


        public EncapCustomer(string first, string last, int age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Unusable string");
                }
                else
                {
                    _firstName = value;
                }
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Unusable string");
                }
                else
                {
                    _lastName = value;
                }
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new Exception("The age is outside the human condition.");
                }
                else
                {
                    _age = value;
                }
            }
        }

    }
}
