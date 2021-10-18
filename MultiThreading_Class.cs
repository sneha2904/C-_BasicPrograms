using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Multithreading
{
    class Myclass
    {
        public void Display()
        {
            Console.WriteLine("Implementing thread1");
            for(int i=0;i<100;i++)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("thread 1 closes");
        }

    }
}
