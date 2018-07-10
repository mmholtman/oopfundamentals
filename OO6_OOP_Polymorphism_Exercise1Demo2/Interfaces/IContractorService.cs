using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Exercise1Demo2
{
    interface IContractor
    {
        bool Create(Contractor contractor);
        Contractor GetById(int contractorId);
        IEnumerable<Contractor> GetAll();
        bool Update(Contractor contractor);
        bool Delete(int contractorId);
    }
}
