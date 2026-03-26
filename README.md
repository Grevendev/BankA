This is a small C# console project that simulates a simple ATM.
The user can insert a card, enter a PIN, view the balance, withdraw money, deposit money, and eject the card.

## Features

- Menu-driven bankomat in the terminal
- Simple login with PIN
- View account balance
- Withdrawals and deposits
- Card ejection and exit

## How the program works

At startup the following is created:

- an account with starting balance `5000`
- a card with number `1234-5678`
- PIN code `1234`
- an bankomat with cash register `11000`

The program then goes through three modes:

1. **Welcome menu** – insert card or exit
2. **PIN menu** – verify PIN
3. **Main menu** – balance, withdrawal, deposit, eject card

## Project structure (brief)

- `Program.cs` – starting point and initialization of demo data
- `ConsoleRunner.cs` – all menu logic and user flows
- `bankomatService.cs` – bankomat state and operations
- `Card.cs` – card information and PIN check
- `Account.cs` – account balance, withdrawals and deposit

Run the project
Requirement: .NET SDK with support for net10.0.

dotnet run
