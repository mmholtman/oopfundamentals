using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO6_OOP_Polymorphism_Exercise1Demo2
{
    interface IStudentService
    {
        bool Create(Student student);
        Student GetById(int studentId);
        IEnumerable<Student> GetAll();
        bool Update(Student student);
        bool Delete(int studentId);

    }
}
