using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name +",");
            
            Console.WriteLine("How many hours of sleep did you get last night?");
            int hos = int.Parse(Console.ReadLine());                                    //hours of sleep
            if(hos>=8)
                {
                Console.WriteLine("You are well rested");
                }
            else
                {
                Console.WriteLine("You need more sleep");
                }               


            Console.ReadKey();
        }
    }
}
