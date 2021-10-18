using System;


namespace Demo_Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imlementing Assemblies in C#!!");

            Stringer myStringInstance = new Stringer();
            Console.WriteLine("Client code executes");
            myStringInstance.stringerMethod();
        }
    
    }
}
