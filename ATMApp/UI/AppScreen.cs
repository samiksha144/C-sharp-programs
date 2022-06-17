using ATMApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();

            Console.Title = "My ATM App";

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n\n----------Welcome to my ATM App----------\n\n");

            Console.WriteLine("Please insert ATM card");

            Console.WriteLine("Note : Actual ATM machine will accept physical ATM card, read card number and validate it.");

            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN.....");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked.Please go to nearest branch to unlock your account.Thank you",true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
    }
}
