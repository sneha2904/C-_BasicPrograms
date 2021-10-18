using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Destructor_Finalizer
{
    class MyClass1:IDisposable
    {
        public void Display()
        {
            Console.WriteLine("Inside Display Metho()");
        }
        public MyClass1()
        {
            Console.WriteLine("Default constructor");

        }
        public MyClass1(string msg)
        {
            Console.WriteLine("Parameterised consteu with a msg{0}",msg);
        }

         ~MyClass1()
         {
             Console.WriteLine("Freeing up resources");
         }
        public void Dispose()
        {
            Console.WriteLine("freeing up resources");
        }



    }
}
