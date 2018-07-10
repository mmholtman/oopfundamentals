using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Exercise1Demo2
{
    interface InstructorServiceInterface
    {
        bool Create(Instructor instructor);
        Instructor GetById(int instructorId);
        IEnumerable<Instructor> GetAll();
        bool Update(Instructor instructor);
        bool Delete(int instructorId);
    }
}
