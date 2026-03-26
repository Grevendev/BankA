using ATM;

public class ATM
{
  public Card? CurrentCard { get; private set; }
  public int MachineBalance { get; private set; }

  public ATM(int initialMachineBalance = 20000)
  {
    MachineBalance = initialMachineBalance;
  }
  public void InsertCard(Card card) => CurrentCard = card;
  public void EjectCard() => CurrentCard = null;

  public bool EnterPin(string pin)
  {
    if (CurrentCard == null) return false;
    return CurrentCard.Pin == pin;
  }
  public bool Withdraw(int amount)
  {
    if (CurrentCard == null) return false;
    if (MachineBalance < amount) return false;
    if (CurrentCard.Account.Balance < amount) return false;

    CurrentCard.Account.Balance -= amount;
    MachineBalance -= amount;
    return true;
  }
}