using ATMApp.UI;

namespace ATMApp.App
{
    internal class ATMApp
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validator.Convert<long>("Your card number");
            Console.WriteLine($"The card number you entered is: {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}