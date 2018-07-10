using System.Collections.Generic;

namespace O6_OOP_Polymorphism_Exercise1Demo
{
    public interface IPerson<T>
    {
        bool Create(T model);
        T GetById(int id);
        IEnumerable<T> GetAll();
        bool Update(T model);
        bool Delete(int id);


    }
}