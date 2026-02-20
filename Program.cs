using System;

class Program
{
    static void Main(string[] args)
    {
        BudgetManager manager = new BudgetManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine("      PERSONAL BUDGET TRACKER     ");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Lägg till transaktion");
            Console.WriteLine("2. Visa alla transaktioner");
            Console.WriteLine("3. Visa total balans");
            Console.WriteLine("4. Ta bort transaktion");
            Console.WriteLine("5. Avsluta programmet");
            Console.WriteLine("----------------------------------");
            Console.Write("Välj ett alternativ (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Lägg till transaktion ---");

                    Console.Write("Beskrivning: ");
                    string description = Console.ReadLine();

                    Console.Write("Belopp (positivt = inkomst, negativt = utgift): ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    Console.Write("Kategori: ");
                    string category = Console.ReadLine();

                    Console.Write("Datum (YYYY-MM-DD): ");
                    string date = Console.ReadLine();

                    Transaction transaction = new Transaction(description, amount, category, date);
                    manager.AddTransaction(transaction);

                    Console.WriteLine("Transaktion tillagd!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Alla transaktioner ---");
                    manager.ShowAll();
                    break;

                case "3":
                    Console.WriteLine("\n--- Total balans ---");
                    decimal balance = manager.CalculateBalance();
                    Console.WriteLine($"Din nuvarande balans är: {balance} kr");
                    break;

                case "4":
                    Console.WriteLine("\n--- Ta bort transaktion ---");
                    Console.Write("Ange index på transaktionen du vill ta bort: ");
                    int index = int.Parse(Console.ReadLine());
                    manager.DeleteTransaction(index);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("\nProgrammet avslutas...");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
}