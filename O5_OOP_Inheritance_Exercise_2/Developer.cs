using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O5_OOP_Inheritance_Exercise_2
{
    public abstract class Developer
    {
        //missing property reference to time. Time is tracked using the other types of developer and skill progression

        public string LastName { get; set; }
        public  bool FinishedTraining { get; set; }
        public  bool FinishedOrientationClass { get; set; }
        public  int PluralsightTrainingHours { get; set; }
        public  Dictionary<string, int> Languages { get; set; }
        protected Developer(bool finishedTraining, bool finishedOrientationClass, 
            int pluralsightTrainingHours, string name)
        {
            FinishedTraining = finishedTraining;
            FinishedOrientationClass = finishedOrientationClass;
            PluralsightTrainingHours = pluralsightTrainingHours;
            LastName = name;
        }
    }
}
