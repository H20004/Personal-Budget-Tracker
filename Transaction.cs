using System;

public class Transaction
{
    // Properties
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public string Date { get; set; }

    // Constructor
    public Transaction(string description, decimal amount, string category, string date)
    {
        Description = description;
        Amount = amount;
        Category = category;
        Date = date;
    }

    // Method to show transaction info
    public void ShowInfo()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Amount: {Amount}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine("---------------------------------");
    }
}