using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Input
    {
        public static int GetInt(string message)
        {
            while ("pigs" != "flying")
            {
                int returnValue;
                Console.WriteLine(message);
                string number = Console.ReadLine();
                if (Int32.TryParse(number, out returnValue))
                {
                    Console.WriteLine(returnValue);
                    return returnValue;
                }
                else
                {
                    Console.WriteLine("Digits for the number please, and a whole number at that.");
                }
            }
            
        }

        public static DateTime getDateTime(string message)
        {
            while ("pigs" != "flying")
            {
                DateTime returnValue;
                Console.WriteLine(message);
                Console.WriteLine("Please format as 'dd/MM/yyyy'");
                string dateTime = Console.ReadLine();
                if (DateTime.TryParse(dateTime, out returnValue))
                {
                    Console.WriteLine(returnValue);
                    return returnValue;
                }
                else
                {
                    Console.WriteLine("Could not parse. Please check the formatting");
                }
            }
            
        }
    }
}
