using ATM;
using Xunit;

public class CardTest
{
  [Fact]
  public void Should_Return_True_When_Pin_Is_Correct()
  {
    var account = new Account(9000);
    var card = new Card("123456", "0123", account);
    var result = card.ValidatePin("0123");
    Assert.True(result);
  }
  [Fact]
  public void Should_Return_False_When_Pin_Is_Wrong()
  {
    var account = new Account(9000);
    var card = new Card("123456", "0123", account);
    var result = card.ValidatePin("1234");
    Assert.False(result);
  }
}