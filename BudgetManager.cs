using System;
using System.Collections.Generic;
using System.Linq;

public class BudgetManager
{
    // List to store all transactions
    private List<Transaction> transactions = new List<Transaction>();

    // Add new transaction
    public void AddTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
        Console.WriteLine("Transaction added successfully!");
    }

    // Show all transactions
   public void ShowAll()
{
    if (transactions.Count == 0)
    {
        Console.WriteLine("Inga transaktioner ännu.");
        return;
    }

    for (int i = 0; i < transactions.Count; i++)
    {
        if (transactions[i].Amount >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        Console.Write($"{i + 1}. ");
        transactions[i].ShowInfo();
        Console.ResetColor();
    }
}

    // Calculate total balance
    public decimal CalculateBalance()
    {
        return transactions.Sum(t => t.Amount);
    }

    // Delete transaction by index
    public void DeleteTransaction(int index)
    {
        if (index >= 0 && index < transactions.Count)
        {
            transactions.RemoveAt(index);
            Console.WriteLine("Transaction removed.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
}