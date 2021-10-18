using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.SqlTypes;

namespace Demo_DLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iplementing using strings

            Console.WriteLine("LINQ Implementation in c#");
            // Specify the data source.
            int[] scores = new int[] { 57, 92, 81, 60 };
            string[] cities = new string[] { "chennai", "banglore", "pune", "goa" };

            // Define the query expression.
            /*IEnumerable<int> scoreQuery =
            from score in scores
            where score > 60
            orderby score descending
            select score;*/
            IEnumerable<string> cityQuery =
            from city in cities
            where city is "pune"
            select city;

            // Execute the query.
            /*foreach (int i in scoreQuery)
            {
                    Console.WriteLine(i + " ");
            }*/
            foreach (var item in cityQuery)
            {
                Console.Write(item + " ");
            }
        }
    }
}
