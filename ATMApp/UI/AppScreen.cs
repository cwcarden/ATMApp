using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            // Add Console clear
            Console.Clear();
            Console.Title = "ATM Application";
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Welcome to ATM APP");
            Console.WriteLine("Please insert ATM Card");

            Console.WriteLine("\n\nPress Enter to continue...\n\n");
        }
    }
}
