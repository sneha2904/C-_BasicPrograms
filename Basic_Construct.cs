using System;

namespace Basic_Construct_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("I am Blessed !!\n");
            Console.WriteLine("enter your favourite snack");
            String Name = Console.ReadLine();
            Console.WriteLine("How many plates will you eat");
            // converting default string value into integer
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Name);
            Console.WriteLine(count);
            if(count>=2)
            {
                Console.WriteLine("Excess junk eating is harmful to health");

            }
            Console.WriteLine("my favourite snack is  " + Name + " I like" + count + "plates to eat");



        }
    }
}
