using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
   public static class Entry
    {
        static void Main(string[] args)
        {

            AppScreen.Welcome();
            ATMApp atmapp = new ATMApp();
            atmapp.InitializeData();
            atmapp.CheckUserCardNumAndPassword();
            atmapp.Welcome();

            
        }

    }
}
