using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //Gather information from user
                Console.WriteLine("Please enter 1st date in the following format:  dd/mm/yyyy");
                DateTime userDate1;
                DateTime userDate2;

                if (DateTime.TryParse(Console.ReadLine(), out userDate1))

                {
                    Console.WriteLine("Awsome! One more time");
                }
                else
                {
                    Console.WriteLine("Pleae formate date as follows:  dd/mm/yyy");
                }
                {
                    Console.WriteLine("Please enter 2nd date in the following format: dd/mm/yyy");
                }
                
                //Convert date and displace difference
                if (DateTime.TryParse(Console.ReadLine(), out userDate2))
                {
                    TimeSpan difference = userDate1.Subtract(userDate2);
                    Console.WriteLine("Those dates are " + difference.TotalDays + " day[s] apart, "
                                                         + difference.TotalHours + " hour[s] apart, and "
                                                         + difference.TotalMinutes + " minute[s] apart");

                }
                else
                {
                    Console.WriteLine("Please format date as follows:  dd/mm/yyy.");

                }
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();

            }
        }
    }
}
