using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O6_OOP_Polymorphism_Exercise1Demo
{
    class ContractorService : IPerson<Contractor>
    {
        public bool Create(Contractor model)
        {
            model.ContractorID = 1;



            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contractor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contractor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contractor model)
        {
            throw new NotImplementedException();
        }
    }
}
