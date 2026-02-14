class BankingView
    {
        public static void DisplayHeader()
        {
            Console.WriteLine("=== Simple ATM System ===");
            Console.WriteLine("Initial Balance: ₱1000.00\n");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Print Mini Statement");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
        }

        public static double GetAmount(string message)
        {
            Console.Write(message);
            double.TryParse(Console.ReadLine(), out double amount);
            return amount;
        }

        public static void ShowBalance(double balance)
        {
            Console.WriteLine($"Current Balance: ₱{balance:F2}");
        }

        public static void ShowDepositSuccess(double balance)
        {
            Console.WriteLine("Deposit successful.");
            Console.WriteLine($"Updated Balance: ₱{balance:F2}");
        }

        public static void ShowWithdrawSuccess(double balance)
        {
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine($"Updated Balance: ₱{balance:F2}");
        }

        public static void ShowInvalidAmount(string type)
        {
            Console.WriteLine($"Invalid {type} amount. Please enter a positive value.");
        }

        public static void ShowInsufficientBalance()
        {
            Console.WriteLine("Withdrawal failed. Insufficient balance.");
        }

        public static void ShowMiniStatement(double balance, double lastTransaction)
        {
            Console.WriteLine("\n--- Mini Statement ---");
            Console.WriteLine($"Current Balance: ₱{balance:F2}");
            Console.WriteLine($"Last Transaction Amount: ₱{lastTransaction:F2}");
        }

        public static void ShowInvalidOption()
        {
            Console.WriteLine("Invalid option selected. Please try again.");
        }

        public static void ShowExitMessage()
        {
            Console.WriteLine("Thank you for using the ATM. Goodbye!");
        }
    }
}
