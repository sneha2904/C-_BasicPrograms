using System;

namespace Eceptional_Handelling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter your favourite num");
                String No = Console.ReadLine();
                Int32.Parse(No);
                Console.WriteLine( "No yo cant't be converted to integer 32");
            }
            catch(FormatException)

            {
                Console.WriteLine("Invalid integer num");
                throw;
            }
            catch(OverflowException)
            {
                Console.WriteLine("value you entered is too big to fit in int32");
            }
            finally
            {
                Console.WriteLine("Hope this object oriented way of exceptional handelling is easy to understand and implement");
            }
        }
    }
}
