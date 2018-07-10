using System;
using System.Runtime.Serialization.Formatters;

namespace O4_OOP_Encapsulation_Exercise_4
{
    public class DeveloperRepo
    {
        public int GetEnrollmentTotal(Developer dev)
        {
            return CalculateEnrollmentTotal(dev);
        }

        private static int CalculateEnrollmentTotal(Developer dev)
        {
            foreach (var course in dev.CourseList)
            {
                SubtractCourseCostFromCurrentBalance(course, dev);

                if (dev.Balance < 0)
                {
                    throw new Exception("Insufficient funds");
                }
                else
                {
                    dev.PurchasedCourses.Add(course);
                }
            }
            
            return dev.Balance;
        }

        private static void SubtractCourseCostFromCurrentBalance(Courses course, Developer dev)
        {
            switch (course)
            {
                case Courses.CalculusI:
                    dev.Balance -= (int)Courses.CalculusI;
                    break;
                case Courses.CalculusII:
                    dev.Balance -= (int)Courses.CalculusII;
                    break;
                case Courses.MusicHistory:
                    dev.Balance -= (int)Courses.MusicHistory;
                    break;
                case Courses.Chemistry:
                    dev.Balance -= (int)Courses.Chemistry;
                    break;
                default:
                    throw new Exception("Course not found. Could not subtract price of unknown course from current balance.");
            }
        }
    }
}