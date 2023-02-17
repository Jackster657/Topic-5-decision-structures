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
            if (Int32.TryParse(Console.ReadLine(), out access1))
            {
                if (access1 == 1)
                {
                    Atm();
                }
            }
            else 
            {

            }
        }
        public static void Atm()
        {
            double bankBalance;
            int access2;
            Console.Clear();
            Console.WriteLine("Welcome to planet Blorgs ATM machine");
            Console.WriteLine("Press 1 for Deposit");
            Console.WriteLine("Press 2 for Withdrawl");
            Console.WriteLine("Press 3 for Bill Payment");
            Console.WriteLine("Press 4 for Acount Balance Update");

            if (Int32.TryParse(Console.ReadLine(), out access2))
            {
                if (access2 == 1)
                {
                    Deposit();
                }
                else if (access2 == 2)
                {
                    Withdrawl();
                }
                else if (access2 == 3)
                {
                    BillPayment();
                }
                else if (access2 == 4)
                {
                    AccountBalanceUpdate();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        public static void Deposit()
        {
            double deposit;
            Console.WriteLine("how much would you like to deposit");
            if (Double.TryParse(Console.ReadLine(), out deposit))
            {

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
        public static void Withdrawl()
        {

        }
        public static void BillPayment()
        {

        }
        public static void AccountBalanceUpdate()
        {

        }
    }
}