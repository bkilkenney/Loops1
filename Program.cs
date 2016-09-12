using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;
            //while(counter <= 7)
            //    {
            //    Console.WriteLine(counter);
            //    counter++; //if this line is missed it will continuously do 0
            //    }

            //int sum = 0;  //setting up variable outside
            //int anotherCounter = 1; 
            //while (anotherCounter <= 10)
            //    {
            //    sum += anotherCounter;
            //    anotherCounter++;
            //    }

            //Console.WriteLine(sum);
            Console.WriteLine("Pick a number");
            int counter2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick 2nd number higher than the first");
            int counter3 = int.Parse(Console.ReadLine());
            while (counter2 <= counter3)
            {
             
                Console.WriteLine(counter2);
                counter2++;
            }
        }
    }
}
