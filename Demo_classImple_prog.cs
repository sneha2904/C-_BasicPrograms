using System;

namespace Demo_Class_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LMS Sneha = new LMS();
            Sneha.Display();
            Sneha.Message();
            Sneha.Placement_Record();
            IAsessement Delhi = Sneha;
            Delhi.MCQ_Asessement();
            Delhi.Questionbank();
            //Placement NIT = new Placement();

        }
    }
}
