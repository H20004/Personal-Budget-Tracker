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
            Console.WriteLine("No transactions found.");
            return;
        }

        foreach (var transaction in transactions)
        {
            transaction.ShowInfo();
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