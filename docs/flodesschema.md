# Flödesschema

```mermaid
flowchart TD
    A([Start]) --> B[Skapa BudgetManager]
    B --> C[Visa meny]
    C --> D[Användaren väljer alternativ]
    D --> E{Val?}

    E -->|1| F[Lägg till transaktion]
    F --> C

    E -->|2| G[Visa alla transaktioner]
    G --> C

    E -->|3| H[Beräkna och visa total balans]
    H --> C

    E -->|4| I[Ta bort transaktion]
    I --> C

    E -->|5| J[Avsluta programmet]
    J --> K([Slut])

    E -->|Ogiltigt val| L[Visa felmeddelande]
    L --> C
    ```