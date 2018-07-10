using System;
using System.Collections.Generic;

namespace O5_OOP_Inheritance_Exercise_2
{
    public class Junior : Developer
    {
        public bool CodingWithIntentCourseCompleted { get; set; }
        public bool ObjectOrientedCourseCompleted { get; set; }
        public Junior(bool finishedTraining, bool finishedOrientationClass, int pluralsightTrainingHours, 
            bool codingWithIntentCourseCompleted, bool objectOrientedCourseCompleted, string name) 
            : base(finishedTraining, finishedOrientationClass, pluralsightTrainingHours, name)
        {
            CodingWithIntentCourseCompleted = codingWithIntentCourseCompleted;
            ObjectOrientedCourseCompleted = objectOrientedCourseCompleted;
        }
    }
}