using System;
namespace Program
{
    public class ATM_OPERATION_PROGRAM
    {
        static double defaultAmountOfMoney = 0;
        static void Main(string[] args)
        {
            string firstPin = "0000";
            int chances = 4;
            for(int i =0;i<=chances;)
            {
                Console.WriteLine("N.B\nThe default Pin is '0000'");
                Console.WriteLine("Please Enter the default pin given from Our branch office!");
                string pin = Console.ReadLine();
                if(firstPin==pin)
                {
                    Console.WriteLine("You have successfully Logged into the ATM Machine!\n\n");
                    Console.WriteLine("**********WELCOME TO ARUA_CITY_CENTENARY_BANK ATM SERVICES**********");
                    i = 5;
                    Display();
                }
                else 
                {
                    Console.WriteLine($"Wrong Attempt,try again. You are remaining with {4-i} Chances");
                    i++;
                }             
            }
        }
        public static void Display()
        {
            Console.WriteLine("The following are the Services we Offer\n");
            Console.WriteLine("1. Create Account\n2. Deposit Cash\n3. Withdraw Cash\n4. Check Balance\n5. Transfer Money\n6. Exit");
            Console.WriteLine("Please Enter your Transaction Option below \n");
            int attempt = int.Parse(Console.ReadLine());
            switch (attempt)
            {
                case 1:
                    Account_Creation();
                    break;
                case 2:
                    AccountDeposit();
                    break;
                case 3:
                    Account_Withdraw();
                    break;
                case 4:
                    AccountBalance();
                    break;
                case 5:
                    Money_Transfer();
                    break;
                case 6:
                    Exit();
                    break;
                default:
                    Console.WriteLine("The Option that you have chosen is not in the above list");
                    Exit();
                    break;
            }
        }

        public static void Account_Creation()
        {
            Console.WriteLine("Would You like to Continue with Account Creation?\n1. Yes\n2. No");
            int opt = int.Parse(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    Console.WriteLine("Please Enter the Pin that you would Prefer for your Account Creation: ");
                    string passwd = Console.ReadLine();

                    for (int i = 0; i < 3;)
                    {
                        Console.WriteLine("Kindly Confirm Your Pin before Your Account is Created:");
                        string ConfPass = Console.ReadLine();

                        if (passwd == ConfPass)
                        {
                            Console.WriteLine("Dear Customer, your Pin is Saved\nYour account has Successfully been Created");
                            Console.WriteLine($"Your Pin is {passwd} and don't share is with any one\n");
                            Console.WriteLine("Thanks for using our Services");
                            i = 9;
                            Exit();
                        }
                        else
                        {
                            Console.WriteLine($"Wrong Confirmation!\nYou are remaining with {3 - i} Attempts");
                            i++;
                        }
                    }
                    break;
                case 2:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Please Make a Correct option from the above");
                    Exit();
                    break;
            }      
        }

        public static void AccountDeposit()
        {
            Console.WriteLine("Are you sure you want to continue with depositing?\n1.Yes\n2.No");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please Enter the Amount you want to deposit:");
                    double money = double.Parse(Console.ReadLine());
                    if(money>=0)
                    {
                        defaultAmountOfMoney = defaultAmountOfMoney + money;
                        Console.WriteLine("You have successfully deposited {0}", money, "your account");
                        Console.WriteLine($"Your account Balance currently is {defaultAmountOfMoney}");
                        Console.WriteLine("Thanks for using our ATM Banking Services!");
                    }
                    else
                    {
                        Console.WriteLine("Please Enter the right Amount");
                    }    
                    Exit();
                    break;
                case 2:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Wrong Choices in relation to the above options");
                    Exit();
                    break;
            }
        }

        public static void Account_Withdraw()
        {
            Console.WriteLine("Would you like to Continue?\n1. Yes\n2. No");
            int opinion = int.Parse(Console.ReadLine());
            switch (opinion)
            {
                case 1:
                    double bank_Amount_current = defaultAmountOfMoney;
                    double bank_Charge = 0.2;
                    Console.WriteLine("Enter the amount to withdraw from your account");
                    double withdraw_amount = double.Parse(Console.ReadLine());
                    double result = bank_Amount_current - withdraw_amount - bank_Charge;
                    Console.WriteLine($"Withdraw of ${withdraw_amount} from Your account is Successful");
                    Console.WriteLine($"Your Balance currently is {result}");
                    Exit();
                    break;
                case 2:
                    Exit();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid option!");
                    Exit();
                    break;
            }
        }

        public static void AccountBalance()
        {
            double balance = defaultAmountOfMoney;

            Console.WriteLine("Would You like to Check your Account Balance?\n1.Yes\n2.No");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine($"Your Balance is {balance}");
                    Console.WriteLine("Thanks for using our ATM Banking Services!");
                    Exit();
                    break;
                case 2:
                    Exit();
                    break;
                default:
                    Console.WriteLine("You have made a wrong option from the Suggestion");
                    Exit();
                    break;
            }
        }
        public static void Money_Transfer()
        {
            Console.WriteLine("Would you Like to transfer Money \n1. Yes\n2. No");
            int transfer = int.Parse(Console.ReadLine());
            switch(transfer)
            {
                case 1:
                    Console.WriteLine("Select the Bank to transfer Money to from the ones Below\n");
                    Console.WriteLine("1. Equity Bank\n2. KCB Bank\n3. CO-Operative Bank\n4. Exit");
                    int bank = int.Parse(Console.ReadLine());
                    switch(bank)
                    {
                        case 1:
                            double tranfer_Charge = 500;
                            double amountBefore = defaultAmountOfMoney;
                            Console.WriteLine("*****Welcome to EQUITY BANK money transfer service*******");
                            Console.WriteLine("Please Enter the Amount to be transfered");
                            double amount = double.Parse(Console.ReadLine());
                            double deduction = amountBefore - tranfer_Charge - amount;
                            if(amountBefore>amount)
                            {
                                Console.WriteLine($"You have successfully Transfered {amount} to Equity bank");
                                Console.WriteLine($"Your Current Balance is ${deduction}");
                                Console.WriteLine("Thanks for using our Services");
                            }
                            else
                            {
                                Console.WriteLine("You have insufficient Amount in your Account");
                                Console.WriteLine($"Your Current balance is ${amountBefore}");
                                Console.WriteLine("Thanks for using our Services");
                            }
                            Exit();
                            break;
                        case 2:
                            double tranfer_Charg = 500;
                            double amountBeforee = defaultAmountOfMoney;
                            Console.WriteLine("*****Welcome to KCB BANK money transfer service*******");
                            Console.WriteLine("Please Enter the Amount to be transfered");
                            double amountt = double.Parse(Console.ReadLine());
                            double deductionn = amountBeforee - tranfer_Charg - amountt;
                            if (amountBeforee > amountt)
                            {
                                Console.WriteLine($"You have successfully Transfered {amountt} to KCB bank");
                                Console.WriteLine($"Your Current Balance is ${deductionn}");
                                Console.WriteLine("Thanks for using our Services");
                            }
                            else
                            {
                                Console.WriteLine("You have insufficient Amount in your Account");
                                Console.WriteLine($"Your Current balance is ${amountBeforee}");
                                Console.WriteLine("Thanks for using our Services");
                            }
                            Exit();
                            break;
                        case 3:
                            double tranfer_Chargee = 500;
                            double amountBeforeee = defaultAmountOfMoney;
                            Console.WriteLine("*****Welcome  Cooperative Bank money transfer service*******");
                            Console.WriteLine("Please Enter the Amount to be transfered");
                            double amounttt = double.Parse(Console.ReadLine());
                            double deductionnn = amountBeforeee - tranfer_Chargee - amounttt;
                            if (amountBeforeee > amounttt)
                            {
                                Console.WriteLine($"You have successfully Transfered {amounttt} to KCB bank");
                                Console.WriteLine($"Your Current Balance is ${deductionnn}");
                                Console.WriteLine("Thanks for using our Services");
                            }
                            else
                            {
                                Console.WriteLine("You have insufficient Amount in your Account");
                                Console.WriteLine($"Your Current balance is ${amountBeforeee}");
                                Console.WriteLine("Thanks for using our Services");
                            }
                            Exit();
                            break;
                        case 4:
                            Exit();
                            break;
                        default:
                            Console.WriteLine("Please your Bank Option Correctly");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Choose a Correct Option from the ones Above!");
                    break;
            }
        }
        public static void Exit()
        {
            Console.WriteLine("You are about to Exit, are you sure about this?\n1.Yes\n2.No");
            int exit = int.Parse(Console.ReadLine());
            switch (exit)
            {
                case 1:
                    break;
                case 2:
                    Display();
                    break;
                default:
                    Console.WriteLine("Wrong selection");
                    break;
            }
        }

    }
}

