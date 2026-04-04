# Klassdiagram

```mermaid
classDiagram
    class Program {
        +Main(string[] args) void
    }

    class BudgetManager {
        -transactions: List~Transaction~
        +AddTransaction() void
        +ShowAll() void
        +CalculateBalance() decimal
        +DeleteTransaction() void
    }

    class Transaction {
        +Description: string
        +Amount: decimal
        +Category: string
        +Date: string
        +ShowInfo() void
    }

    Program --> BudgetManager : använder
    BudgetManager "1" *-- "0..*" Transaction : innehåller
    ```