namespace Topic_5_decision_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int access1;
            Console.WriteLine("Which program would you like to run?");
            Console.WriteLine("Press 1 for ATM");
            Console.WriteLine("Press 2 for Parking");
            Console.WriteLine("press 3 for hurricane");
            Console.WriteLine("Press 4 to close");
            if (Int32.TryParse(Console.ReadLine(), out access1))
            {
                if (access1 == 1)
                {
                    Atm();
                }
                else if (access1 == 2)
                {
                    Parking();
                }
                else if (access1 == 3)
                {
                    Hurricane();
                }
                else if (access1 == 4)
                {
                    Environment.Exit(1);
                }
            }
            else 
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public static void Atm()
        {
            double bankBalance = 146;
            int access2;
            Console.Clear();
            Console.WriteLine("Welcome to planet Blorgs ATM machine");
            Console.WriteLine("Press 1 for Deposit");
            Console.WriteLine("Press 2 for Withdrawl");
            Console.WriteLine("Press 3 for Bill Payment");
            Console.WriteLine("Press 4 for Acount Balance Update");
            Console.WriteLine("Press 5 to close");

            if (Int32.TryParse(Console.ReadLine(), out access2))
            {
                if (access2 == 1)
                {
                    bankBalance = Deposit(bankBalance);
                }
                else if (access2 == 2)
                {
                    bankBalance = Withdrawl(bankBalance);
                }
                else if (access2 == 3)
                {
                    bankBalance = BillPayment(bankBalance);
                }
                else if (access2 == 4)
                {
                    AccountBalanceUpdate(bankBalance);
                }
                else if (access2 == 5)
                {
                    Environment.Exit(1);
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public static double Deposit(double balance)
        {
            double deposit;
            Console.WriteLine("how much would you like to deposit");
            if (Double.TryParse(Console.ReadLine(), out deposit))
            {
                balance += deposit;
                balance -= 0.75;
                Console.WriteLine("Your balance is " + balance + ", Press enter to continue");
                Console.ReadLine();
                return balance;
                
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return balance;
            }

        }
        public static double Withdrawl(double balance)
        {
            double withdraw;
            Console.WriteLine("how much would you like to withdraw");
            if (Double.TryParse(Console.ReadLine(), out withdraw))
            {
                balance -= withdraw;
                balance -= 0.75;
                Console.WriteLine("Your balance is " + balance + ", Press enter to continue");
                Console.ReadLine();
                return balance;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return balance;
            }

        }
        public static double BillPayment(double balance)
        {
            double billPayment;
            if (Double.TryParse(Console.ReadLine(), out billPayment))
            {
                balance -= billPayment;
                balance -= 0.75;
                Console.WriteLine("Your balance is " + balance + ", Press enter to continue");
                Console.ReadLine();
                return balance;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return balance;
            }
        }
        public static void AccountBalanceUpdate(double balance)
        {
            Console.WriteLine("Your balance is " + balance + ", Press enter to continue");
            Console.ReadLine();
        }
        public static void Parking()
        {
            double time;
            double bill = 2;

            Console.WriteLine("Welcome To the paid parking lot, how long will you be parked for (in minutes)");
            if (Double.TryParse(Console.ReadLine(), out time))
            {
                time /= 60;
                time = Math.Ceiling(time);
                bill *= time;
                bill += 4;
                Console.WriteLine("your bill is "   + bill.ToString("C"));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
           

        }
        public static void Hurricane()
        {
            int level = 0;
            Console.WriteLine("What catagory is the hurricane(only Number)");
            level = Convert.ToInt32(Console.ReadLine());
            switch (level)
            {
                case 1:
                    Console.WriteLine("the wind speed of your hurricane is 74-95 mph 64-82 kt 119-153 km/h");
                    break;
               
                case 2:
                    Console.WriteLine("the wind speed of your hurricane is 96-110 mph 83-95 kt 154-177 km/h");
                    break;

                case 3:
                    Console.WriteLine("the wind speed of your hurricane is 111-129 mph 96-112 kt 178-208 km/h");
                    break;

                case 4:
                    Console.WriteLine("the wind speed of your hurricane is 130-156 mph 113-136 kt 209-251 km/h");
                    break;
                case 5:
                    Console.WriteLine("the wind speed of your hurricane is 158+ mph 137+ kt 254+ km/h");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break ;
                    



            }

        }

    }
}