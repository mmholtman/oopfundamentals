using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O4_OOP_Encapsulation_Exercise_4
{
    public class Developer
    {
        public int Balance { get; set; }
        public List<Courses> CourseList { get; private set; }

        public List<Courses> PurchasedCourses { get; set; }

        public Developer(List<Courses> list, int balance)
        {
            CourseList = list;
            Balance = balance;
        }
    }
}
