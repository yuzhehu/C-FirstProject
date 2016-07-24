using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Class4;

namespace Project1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Lol");
            Class1 cl = new Class1();
            Class4 cl2 = new Class4();
            Class5 cl3 = new Class5();
            Class6 cl4 = new Class6();
            //it seems that having multiple class added in the same namespace will not need to import them
            //solution explorer must have the .cs files (class files). 

        }

        public Class1()
        {
            Console.WriteLine("what");
        }
    }

    
}
