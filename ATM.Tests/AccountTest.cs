public class AccountTests
{
  [Fact]
  public void Account_ShouldStoreBalance()
  {
    var account = new Account(5000);
    Assert.Equal(5000, account.Balance);
  }
}
