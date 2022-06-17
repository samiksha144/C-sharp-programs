using ATMApp.Domain.Entities;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;

namespace ATMApp
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id = 1, FullName = "Pooja", AccountNumber = 1236547, CardNumber = 1856996, CardPin = 123654, AccountBalance = 100000.00m, IsLocked = false},
                new UserAccount{Id = 2, FullName = "Samiksha", AccountNumber = 123456, CardNumber = 856942, CardPin = 123456, AccountBalance = 50000.00m, IsLocked = false},
                new UserAccount{Id = 3, FullName = "Manasi", AccountNumber = 1285623, CardNumber = 4699336, CardPin = 789654, AccountBalance = 30000.00m, IsLocked = false}
            };

        }

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while(isCorrectLogin==false)
            {
                UserAccount inputAccount = AppScreen.UserLoginForm();

                AppScreen.LoginProgress();
                foreach(UserAccount account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber)) 
                    {
                        selectedAccount.TotalLogin++;

                        if(inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = account;

                            if (selectedAccount.IsLocked || selectedAccount.TotalLogin >3)
                            {
                                AppScreen.PrintLockScreen();

                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }

                            
                        }    
                    }
                }

            }
            if(isCorrectLogin==false)
            {
                Utility.PrintMessage("\nInvalid card number or PIN", false);
                selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                if(selectedAccount.IsLocked)
                {
                    AppScreen.PrintLockScreen();
                }
            }
            Console.Clear();
           
        }
        public void Welcome()
        {
            Console.WriteLine($"Welcome back,{selectedAccount.FullName}");
        }
       
    }
}