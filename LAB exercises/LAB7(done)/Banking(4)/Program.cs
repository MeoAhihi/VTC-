var accBill = new Account("Bill Gate", 12345, 1E5);
accBill.getBalance();

accBill.Deposit(5E4);
accBill.getBalance();

accBill.Withdraw(4200);
accBill.getBalance();

accBill.Withdraw(2E5);
accBill.getBalance();