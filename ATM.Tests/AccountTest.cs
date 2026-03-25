namespace ATM.ATM.Tests;

using ATM;
using Xunit;

public class AccountTest
{
  [Fact]
  public void GetBalanceTest()
  {
    // setup
    Account account = new Account(5000);

    // test
    Assert.Equal(5000, account.GetBalance());
  }
}