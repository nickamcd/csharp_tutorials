namespace MyBank
{
	class Program
	{
		static void Main(string[] args)
		{
      var account = new BankAccount("Nick", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

      account.MakeWithdrawal(120, DateTime.Now, "Theme park ticket");
      Console.WriteLine($"Account now has a balance of {account.Balance}");

      try
      {
        var invalidAccount = new BankAccount("invalid", -100);
      }
      catch (ArgumentOutOfRangeException e)
      {
        Console.WriteLine("Exception caught creating account with negative balance");
        Console.WriteLine(e.ToString());
      }

      account.MakeWithdrawal(25, DateTime.Now, "Dinner");
      Console.WriteLine(account.Balance);

      Console.WriteLine(account.GetAccountHistory());
		}
	}
}