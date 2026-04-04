# Personal Budget Tracker

## Projektbeskrivning
Detta projekt är ett menybaserat konsolprogram i C# där användaren kan hålla koll på inkomster och utgifter. Programmet använder objektorienterad programmering med klasserna `Transaction` och `BudgetManager`.

## Funktioner
- Lägga till transaktioner
- Visa alla transaktioner
- Visa total balans
- Ta bort transaktioner
- Färgmarkering i konsolen:
  - Grön = inkomst
  - Röd = utgift

## Klasser
### Transaction
Representerar en enskild transaktion och innehåller:
- Description
- Amount
- Category
- Date

Metod:
- `ShowInfo()`

### BudgetManager
Ansvarar för listan av transaktioner och innehåller metoder för att:
- lägga till transaktioner
- visa alla transaktioner
- räkna ut balans
- ta bort transaktioner

## Hur man kör programmet
1. Öppna projektet i VS Code eller Visual Studio
2. Öppna terminalen
3. Kör kommandot:

```bash
dotnet run
``` 

## Namn och datum

Namn: Hirad Farsi
Datum: 2026-03-09

## Reflektionsfrågor
### Hur hjälpte klasser och metoder dig att organisera programmet?

Klasser och metoder gjorde programmet mer organiserat och lättare att förstå. Klassen Transaction lagrar information om varje transaktion, medan BudgetManager hanterar logiken. Det gjorde att koden blev tydligare och lättare att arbeta med.

### Vilken del av projektet var mest utmanande?

Den mest utmanande delen var att påbörja klassdiagrammet och flödesdiagrammet och att se till att alla val fungerade korrekt. 

## Diagram
- [Klassdiagram](docs/klassdiagram.md)
- [Flödesschema](docs/flodesschema.md)