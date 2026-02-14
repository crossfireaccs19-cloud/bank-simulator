 class BankingService
    {
        private static double lastTransactionAmount = 0.0;

        // Pass-by-value
        public static double CheckBalance(double balance)
        {
            return balance;
        }

        // ref
        public static bool Deposit(ref double balance, double amount)
        {
            if (amount <= 0)
                return false;

            balance += amount;
            lastTransactionAmount = amount;
            return true;
        }

        // ref + out
        public static void Withdraw(ref double balance, double amount, out bool isSuccessful)
        {
            if (amount <= 0 || amount > balance)
            {
                isSuccessful = false;
                return;
            }

            balance -= amount;
            lastTransactionAmount = amount;
            isSuccessful = true;
        }

        // Pass-by-value
        public static void GetMiniStatement(double balance, out double lastTransaction)
        {
            lastTransaction = lastTransactionAmount;
        }
    }
