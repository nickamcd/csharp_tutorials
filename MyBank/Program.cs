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
		}
	}
}