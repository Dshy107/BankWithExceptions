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
            BankAccount theAccount = new BankAccount(25.0);

            theAccount.Deposit(2000);
            try
            {
                theAccount.Illigal(25.0);
            }
            catch (IllegalInterestRateException)
            {

                Console.WriteLine("STOP!! This is an illigal action!");
            }
            try
            {
            // Should this be legal...?
            theAccount.Deposit(-1000);
            }
            catch (NegativeAmountException)
            {

                Console.WriteLine("STOP!! You can't deposit a negativ amount");
            }
           

            // Try to withdraw...
            try
            {
                theAccount.Withdraw(3000);
            }
            catch (WithdrawAmountTooLargeException)
            {
                Console.WriteLine("You tried to withdraw too much money!");
            }


            Console.WriteLine("Balance is now : " + theAccount.GetBalance());

            // The LAST line of code should be ABOVE this line
        }
    }
}
