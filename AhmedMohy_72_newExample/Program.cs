
BankAccount myAccount1 = new BankAccount();
myAccount1.BankName = "Bank of Egypt";
myAccount1.BranchName = "Cairo Branch";
myAccount1.BranchAddress = "456 Nile St, Cairo, Egypt";
myAccount1.AccountNumber = "EG456789";
myAccount1.AccountCurrency = "EGP";
myAccount1.AccountBalance = 2000;

    BankAccount myAccount2 = new BankAccount();
myAccount2.BankName = "Bank of America";
myAccount2.BranchName = "Downtown Branch";
myAccount2.BranchAddress = "123 Main St, Anytown, USA";
myAccount2.AccountNumber = "DF236789";
myAccount2.AccountCurrency = "USD";
myAccount2.AccountBalance = 1500;


Console.WriteLine($"Bank Name: {myAccount1.BankName}");
Console.WriteLine($"Branch Name: {myAccount1.BranchName}");
Console.WriteLine($"Branch Address: {myAccount1.BranchAddress}");
Console.WriteLine($"Account Number: {myAccount1.AccountNumber}");
Console.WriteLine($"Account Currency: {myAccount1.AccountCurrency}");
Console.WriteLine($"Account Balance: {myAccount1.AccountBalance}");
Console.WriteLine("---------------------------");


Console.WriteLine($"Bank Name: {myAccount2.BankName}");
Console.WriteLine($"Branch Name: {myAccount2.BranchName}");
Console.WriteLine($"Branch Address: {myAccount2.BranchAddress}");
Console.WriteLine($"Account Number: {myAccount2.AccountNumber}");
Console.WriteLine($"Account Currency: {myAccount2.AccountCurrency}");
Console.WriteLine($"Account Balance: {myAccount2.AccountBalance}");
Console.WriteLine("---------------------------");
myAccount1.Deposit(500);
myAccount1.Withdraw(200);
Console.WriteLine($"Account Balance One : {myAccount1.AccountBalance}");
Console.WriteLine("---------------------------------");
myAccount2.Deposit(1000);
myAccount2.Withdraw(500);
Console.WriteLine($"Account Balance Tow : {myAccount2.AccountBalance}");
Console.WriteLine("----------------------------------");
myAccount1.Transfer(myAccount2, 300);
Console.WriteLine("After Transfer.");
Console.WriteLine($"Account Balance Two: {myAccount2.AccountBalance}");
Console.WriteLine($"Account Balance One : {myAccount1.AccountBalance}");


Console.ReadLine();
class BankAccount
{
    public string BankName { get; set; }

    public string BranchName { get; set; }

    public string BranchAddress { get; set; }

    public string AccountNumber { get; set; }

    public string AccountCurrency { get; set; }

    public decimal AccountBalance { get;  set; }





    public void Withdraw(decimal amount)
    {
        decimal newBalance = AccountBalance - amount;
        if (newBalance < 0)
        {
            Console.WriteLine("Invalid transaction");
        }

        else
        {
            Console.WriteLine($"Withdraw amount : {amount}");
            Console.WriteLine($"Your new balance for {AccountNumber} is {newBalance}");
            AccountBalance = newBalance;
            Console.WriteLine($"Transaction Date: {DateTime.Now}");
        }



    }

    public void Deposit(decimal Amount)
    {
        decimal newBalance = AccountBalance + Amount;
        Console.WriteLine($"Deposit amount : {Amount}");
        Console.WriteLine($"Your new balance for {AccountNumber} is {newBalance}");
        Console.WriteLine($"Transaction Date: {DateTime.Now}");
        AccountBalance = newBalance;

    }


    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        decimal newBalance =  AccountBalance - amount;

        if(newBalance < 0)
        {
            Console.WriteLine("Invaled Transactinn. ");
        }
        else
        {
            AccountBalance = newBalance;
            targetAccount.AccountBalance += amount;

            Console.WriteLine($"Transfer amont : {amount}");
            Console.WriteLine($"Your new balance : {AccountBalance}");
            Console.WriteLine($"Target account new balance : {targetAccount}");
            Console.WriteLine($"Transaction Date : {DateTime.Now}");
        }

    }


    public void ChangePassword() { }
    public void CreateSubAccount() { }
    public void PrintStatement() { }

    
}

//BankAccount myAccountTow = new BankAccount(2000);

//myAccount.AccountBalance = 2000;










