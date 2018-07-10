using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_ClaimDates
{
    struct ClaimDates{

        public TimeSpan ClaimTimeSpan { get; set; }
        public int ClaimCost { get; set; }
        public bool RedirectedToTelephone { get; set; }

        public int DaysAfterIncident { get; set; }

        public ClaimDates(TimeSpan claimTimeSpan, int claimCost, bool redirectedToTelephone, int daysAfterIncident) : this()
        {
            ClaimTimeSpan = claimTimeSpan;
            ClaimCost = claimCost;
            RedirectedToTelephone = redirectedToTelephone;
            DaysAfterIncident = daysAfterIncident;
        }
    }
}
