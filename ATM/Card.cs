public class Card
{
    public string Pin { get; }
    public Account Account { get; }

    public Card(string pin, Account account)
    {
        Pin = pin;
        Account = account;
    }
}
