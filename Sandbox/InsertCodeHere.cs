using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new bank account with 25 % interest rate
            // (is that legal...?)
            BankAccount theAccount;

            try
            {
                theAccount = new BankAccount(15.0);
            }
            catch (IllegalInterestRateException)
            {
                Console.WriteLine("Illegal intest rate. The interest rate must be between 0.0 and 20.0 %");
                return;
            }
            // Make a deposit

            try
            {
                theAccount.Deposit(2000);
            }
            catch (NegativeAmountException)
            {
                Console.WriteLine("Illegal amount. Must be positive!");
                return;
            }



            //    Should this be legal...?


            //    Try to withdraw...
            try
            {
                theAccount.Withdraw(500);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
                return;
            }

            Console.WriteLine("Balance is now : " + theAccount.GetBalance());
      
    // The LAST line of code should be ABOVE this line
}
    }
}
