public class CardTests
{
  [Fact]
  public void Card_ShouldStorePinAndAccount()
  {
    var account = new Account(10000);
    var card = new Card("0123", account);

    Assert.Equal("0123", card.Pin);
    Assert.Equal(account, card.Account);
  }
}
