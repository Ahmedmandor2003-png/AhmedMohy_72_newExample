
BankAccount myAccount1 = new BankAccount();
myAccount1.ClientName = "Ahmed";
myAccount1.BankName = "Bank of Egypt";
myAccount1.BranchName = "Cairo Branch";
myAccount1.BranchAddress = "456 Nile St, Cairo, Egypt";
myAccount1.AccountNumber = "EG456789";
myAccount1.AccountCurrency = "EGP";
myAccount1.AccountBalance = 2000;


BankAccount myAccount2 = new BankAccount();
myAccount2.ClientName = "David";
myAccount2.BankName = "Bank of America";
myAccount2.BranchName = "Downtown Branch";
myAccount2.BranchAddress = "123 Main St, Anytown, USA";
myAccount2.AccountNumber = "DF236789";
myAccount2.AccountCurrency = "USD";
myAccount2.AccountBalance = 1500;

Console.WriteLine($"Ownar Name: {myAccount1.ClientName}");
Console.WriteLine($"Bank Name: {myAccount1.BankName}");
Console.WriteLine($"Branch Name: {myAccount1.BranchName}");
Console.WriteLine($"Branch Address: {myAccount1.BranchAddress}");
Console.WriteLine($"Account Number: {myAccount1.AccountNumber}");
Console.WriteLine($"Account Currency: {myAccount1.AccountCurrency}");
Console.WriteLine($"Account Balance: {myAccount1.AccountBalance}");
Console.WriteLine("---------------------------");
Console.WriteLine($"Owner Name: {myAccount2.ClientName}");
Console.WriteLine($"Bank Name: {myAccount2.BankName}");
Console.WriteLine($"Branch Name: {myAccount2.BranchName}");
Console.WriteLine($"Branch Address: {myAccount2.BranchAddress}");
Console.WriteLine($"Account Number: {myAccount2.AccountNumber}");
Console.WriteLine($"Account Currency: {myAccount2.AccountCurrency}");
Console.WriteLine($"Account Balance: {myAccount2.AccountBalance}");
Console.WriteLine("---------------------------");
myAccount1.Deposit(500);
myAccount1.Withdraw(400);
Console.WriteLine($"Account Balance One : {myAccount1.AccountBalance}");
Console.WriteLine("---------------------------------");
myAccount2.Deposit(1000);
myAccount2.Withdraw(500);
Console.WriteLine($"Account Balance Two : {myAccount2.AccountBalance}");
Console.WriteLine("----------------------------------");
myAccount1.Transfer(myAccount2, 300);
Console.WriteLine("After Transfer.");
Console.WriteLine($"Account Balance Two: {myAccount2.AccountBalance}");
Console.WriteLine($"Account Balance One : {myAccount1.AccountBalance}");
Console.WriteLine("----------Statement----------");
 

myAccount1.PrintStatement();
myAccount2.PrintStatement();

Console.ReadLine();


class BankAccount
{
    public string ClientName {  get; set; }
    public string BankName { get; set; }

    public string BranchName { get; set; }

    public string BranchAddress { get; set; }

    public string AccountNumber { get; set; }

    public string AccountCurrency { get; set; }

    public decimal AccountBalance { get;  set; }




    public void Withdraw(decimal amont)

    {
        decimal TransactionFees = amont * 0.005m;// 0.5% of the transaction amount

        decimal newBalance = AccountBalance - amont - TransactionFees;


        if (newBalance < 0)
        {
            Console.WriteLine("Invalid transaction..........");
        }

        if (amont <= 0)
        {
            Console.WriteLine("Invalid Amount.........");
            return;
        }

        else
        {
            Console.WriteLine($"Withdraw amont : {amont}  From {AccountNumber}");
            Console.WriteLine($"Your new balance for {AccountNumber} is {newBalance}");
            AccountBalance = newBalance;
            Console.WriteLine($"Transaction Date: {DateTime.Now}");
        }



    }

    public void Deposit(decimal amont)

    {
        decimal TransactionFees = amont * 0.005m; // 0.5% of the transaction amount

        if (amont <= 0)
        {
            Console.WriteLine("Invaled Amount.........");
            return;
        }
        decimal newBalance = AccountBalance + amont - TransactionFees;
        Console.WriteLine($"Deposit amont : {amont} To --> {AccountNumber}");
        Console.WriteLine($"Your new balance for {AccountNumber} is {newBalance}");
        Console.WriteLine($"Transaction Date: {DateTime.Now}");
        AccountBalance = newBalance;

    }


    public void Transfer(BankAccount targetAccount, decimal amont)

    {
        decimal TransactionFees = amont * 0.005m; // 0.5% of the transaction amount
        decimal newBalance =  AccountBalance - amont - TransactionFees;

        if(newBalance < 0)
        {
            Console.WriteLine("Invalid Transaction....... ");
        }

        if (amont <= 0)
        {
            Console.WriteLine("Invalid Amont.......");
            return;
        }
        else
        {
            AccountBalance = newBalance;
            targetAccount.AccountBalance += amont;

            Console.WriteLine($"Transfer amont : {amont} from {AccountNumber}");
            Console.WriteLine($"Your new balance : {AccountBalance} {AccountNumber}");
            Console.WriteLine($"Target account new balance : {targetAccount.AccountBalance}");
            //Console.WriteLine($"Target account new balance : {targetAccount}");
            Console.WriteLine($"Transaction Date : {DateTime.Now}");
        }

    }
     
    public void PrintStatement() 
    
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Balance: {AccountBalance}");
        Console.WriteLine($"Account Currency: {AccountCurrency}");
    }
    public void ChangePassword() { }
    public void CreateSubAccount() { }
   

    
}

//BankAccount myAccountTow = new BankAccount(2000);

//myAccount.AccountBalance = 2000;










