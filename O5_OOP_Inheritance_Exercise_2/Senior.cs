using System;
using System.Collections.Generic;

namespace O5_OOP_Inheritance_Exercise_2
{
    public class Senior : Developer
    {
        public bool MiniLessonsCompleted { get; set; }
        public Senior(bool finishedTraining, bool finishedOrientationClass, 
            int pluralsightTrainingHours, bool miniLessonsCompleted, string name) 
            : base(finishedTraining, finishedOrientationClass, pluralsightTrainingHours, name)
        {
            MiniLessonsCompleted = miniLessonsCompleted;
        }

        
    }
}