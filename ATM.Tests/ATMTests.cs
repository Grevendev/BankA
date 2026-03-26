public class ATMTests
{
  [Fact]
  public void InsertCard_ShouldSetCurrentCard()
  {
    var atm = new ATM();
    var card = new Card("0123", new Account(10000));

    atm.InsertCard(card);

    Assert.Equal(card, atm.CurrentCard);
  }

  [Fact]
  public void EnterPin_WrongPin_ShouldReturnFalse()
  {
    var atm = new ATM();
    var card = new Card("0123", new Account(10000));
    atm.InsertCard(card);

    var result = atm.EnterPin("1234");

    Assert.False(result);
  }

  [Fact]
  public void EnterPin_CorrectPin_ShouldReturnTrue()
  {
    var atm = new ATM();
    var card = new Card("0123", new Account(10000));
    atm.InsertCard(card);

    var result = atm.EnterPin("0123");

    Assert.True(result);
  }

  [Fact]
  public void Withdraw_ShouldReduceAccountAndAtmBalance()
  {
    var atm = new ATM(initiaMachineBalance: 10000);
    var card = new Card("0123", new Account(10000));
    atm.InsertCard(card);
    atm.EnterPin("0123");

    var result = atm.Withdraw(5000);

    Assert.True(result);
    Assert.Equal(5000, card.Account.Balance);
    Assert.Equal(5000, atm.MachineBalance);
  }

  [Fact]
  public void Withdraw_ShouldFail_WhenAtmHasInsufficientFunds()
  {
    var atm = new ATM(initialMachineBalance: 6000);
    var card = new Card("0123", new Account(10000));
    atm.InsertCard(card);
    atm.EnterPin("0123");

    var result = atm.Withdraw(7000);

    Assert.False(result);
  }

  [Fact]
  public void Withdraw_ShouldFail_WhenAccountHasInsufficientFunds()
  {
    var atm = new ATM(initialMachineBalance: 6000);
    var card = new Card("0123", new Account(5000));
    atm.InsertCard(card);
    atm.EnterPin("0123");

    var result = atm.Withdraw(6000);

    Assert.False(result);

  }

  [Fact]
  public void EjectCard_ShouldRemoveCurrentCard()
  {
    var atm = new ATM();
    var card = new Card("0123", new Account(10000));
    atm.InsertCard(card);

    atm.EjectCard();

    Assert.Null(atm.CurrentCard);
  }
}