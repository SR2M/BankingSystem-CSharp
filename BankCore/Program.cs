// Console.WriteLine("=== BankCore Banking System ===");

// var savingAccount = new SavingAccont("SA-1001", "Mona");

// savingAccount.Deposit(10_000_000m);

// Console.WriteLine($"Owner: {savingAccount.OwnerName}");
// Console.WriteLine($"Account: {savingAccount.AccountNumber}");
// Console.WriteLine($"Balance: {savingAccount.Balance}");

// // bool success = account.Withdraw(3_000_000m);

// // Console.WriteLine($"Withdrawal successful: {success}");
// // Console.WriteLine($"Balance: {account.Balance}");

//-----------------------------------------------------------------------------------------------------------
// var currentAccount = new CurrentAccount(
//     "CA-1001",
//     "Mona",
//     500_000_000m
// );

// currentAccount.Deposit(2_000_000m);

// bool result = currentAccount.Withdraw(6_000_000m);

// Console.WriteLine($"Balance: {currentAccount.Balance}");
//-------------------------------------------------------------------------------------------------------------
// Account saving = new  SavingAccont("SA-1001", "Mona");

// Account current = new CurrentAccount("CA_1001", "Mona", 500_000_000m);

// saving.Deposit(10_000_000m);
// current.Deposit(10_000_000m);

// Console.WriteLine(saving.Withdraw(12_000_000m));
// Console.WriteLine(current.Withdraw(12_000_000m));
//--------------------------------------------------------------------------------------------------------------
// Account source = new SavingAccont("SA-1001", "Mona");
// Account destination = new CurrentAccount("CA-1001", "Sara", 5_000_000m);

// source.Deposit(10_000_000);
// var transactionService = new TransactionService();

// bool result = transactionService.Transfer(source, destination, 3_000_000m);

// Console.WriteLine($"Transfer successful: {result}");
// Console.WriteLine($"Mona balance: {source.Balance}");
// Console.WriteLine($"Sara balance: {destination.Balance}");
//----------------------------------------------------------------------------------------------------------------
var notificationService = new ConsoleNotificationService();
var bankService = new BankService(notificationService);

bankService.NotifyTransfer();

