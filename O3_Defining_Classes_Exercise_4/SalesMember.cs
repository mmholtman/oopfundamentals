using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace O3_Defining_Classes_Exercise_4
{
    public class SalesMember
    {

        public string LastName { get; set; }
        public int TotalSalesForCurrentMonth { get; set; }
        public SalesMember()
        {
        }

        public SalesMember(string lastName, int totalSalesForCurrentMonth)
        {
            LastName = lastName;
            TotalSalesForCurrentMonth = totalSalesForCurrentMonth;
        }



    }

    public class SalesMemberRepo
    {
        private readonly List<SalesMember> _salesTeam;

        public SalesMemberRepo()
        {
            _salesTeam = new List<SalesMember>();
        }

        public List<SalesMember> AddMemberToList(SalesMember s)
        {
            _salesTeam.Add(s);
            return _salesTeam;
        }

        public int GetListCount()
        {
            return _salesTeam.Count;
        }

        public int GetTotalTeamSales()
        {
            int total = 0;

            foreach (var i in _salesTeam)
            {
                total += i.TotalSalesForCurrentMonth;
            }
            
            return total;
        }

    }
}
