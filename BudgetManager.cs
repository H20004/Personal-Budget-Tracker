using System;
using System.Collections.Generic;

public class BudgetManager
{
    private List<Transaction> transactions = new List<Transaction>();

    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
        Console.WriteLine("Transaction added successfully!");
    }

    public void ShowAll()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("Inga transaktioner ännu.");
            return;
        }

        for (int i = 0; i < transactions.Count; i++)
        {
            Console.WriteLine($"\nIndex: {i}");

            if (transactions[i].Amount >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            transactions[i].ShowInfo();
            Console.ResetColor();
        }
    }

    public decimal CalculateBalance()
    {
        decimal total = 0;

        foreach (Transaction transaction in transactions)
        {
            total += transaction.Amount;
        }

        return total;
    }

    public void DeleteTransaction(int index)
    {
        if (index >= 0 && index < transactions.Count)
        {
            transactions.RemoveAt(index);
            Console.WriteLine("Transaktionen togs bort.");
        }
        else
        {
            Console.WriteLine("Ogiltigt index.");
        }
    }
}