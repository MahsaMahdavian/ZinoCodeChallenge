using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinoCodeChallenge
{
    public class Display
    {
        static public int DisplayMenu()
        {
            Console.WriteLine("Unit Convertor");
            Console.WriteLine();
            Console.WriteLine("1. Choose the unit you want change ");
            Console.WriteLine("2. mm to km");
            Console.WriteLine("3. Search for a Football team");
            Console.WriteLine("4. Delete a team");
            Console.WriteLine("5. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
