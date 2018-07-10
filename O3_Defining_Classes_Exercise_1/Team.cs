using System;
using System.Collections.Generic;

namespace O3_Defining_Classes_Exercise_1
{
    public class Team
    {
        public List<Developers> DevTeam { get; set; }

        public  Team()
        {
            DevTeam = new List<Developers>();
        }

        public void AddDevelopersToTeam()
        {
            var maxDev = new Developers(1, "Holtman", true);
            var jaredDev = new Developers(2, "Niemeier", false);
            var evanDev = new Developers(3, "Havlin", true);

            DevTeam.Add(maxDev);
            DevTeam.Add(jaredDev);
            DevTeam.Add(evanDev);
        }
    }

    public class Developers
    {

        public int DeveloperId { get; set; }
        public string LastName { get; set; }
        public bool HasPluralsightAccount { get; set; }

        public Developers(int developerId, string lastName, bool hasPluralsightAccount)
        {
            DeveloperId = developerId;
            LastName = lastName;
            HasPluralsightAccount = hasPluralsightAccount;
        }

        public override string ToString()
        {
            return $"{DeveloperId} {LastName} {HasPluralsightAccount}";
        }
    }
}