using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _O6_OOP_Polymorphism_Demo_4.Contracts
{
    public interface ISwipeable
    {
        void Accept();
        void Decline();
        void Swipe();
    }
}
