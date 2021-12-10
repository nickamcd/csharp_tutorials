namespace MyBank
{
	class BankAccount
	{
		public string Number { get; }

    public string Owner { get; set; }

    public decimal Balance { get; }

    public BankAccount(string name, decimal initialBalance) // default constructor
    {
      this.Owner = name;
      this.Balance = initialBalance;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {

    }
	}
}