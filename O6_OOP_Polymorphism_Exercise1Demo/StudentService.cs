using System.Collections.Generic;

namespace O6_OOP_Polymorphism_Exercise1Demo
{
    public class StudentService : IPerson<Student>
    {
        public bool Create(Student model)
        {
            model.StudentID = 1;
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Student model)
        {
            throw new System.NotImplementedException();
        }
    }
}