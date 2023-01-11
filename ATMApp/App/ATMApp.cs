using ATMApp.UI;

namespace ATMApp.App
{
    internal class ATMApp
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            string cardNumber = Utility.GetUserInput("Please enter your card number.");
            Console.WriteLine($"The card number you entered is: {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}