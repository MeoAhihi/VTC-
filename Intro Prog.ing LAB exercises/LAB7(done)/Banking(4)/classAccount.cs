class Account {
    private int account;
    private string name;
    private double balance;
    private double interestRate;

    public Account(string name, int account, double balance) {
        this.name = name;
        this.account = account;
        this.balance = balance;
    }

    public double Deposit(double money) {
        if (money < 0) {System.Console.WriteLine("Error: Invalid deposit money!");}
        else {balance += money;}
        return balance;
    }

    public double Withdraw(double money) {
        if (money < 0) {System.Console.WriteLine("Error: Invalid deposit money!");}
        else if (money > balance) {System.Console.WriteLine("Error: Not enough money!");}
        else {balance -= money;}
        return balance;
    }

    public double BalanceGain() {
        balance += balance * interestRate;
        return balance;
    }

    public int getAccountNumber() {
        return account;
    }

    public double getBalance() {
        System.Console.WriteLine("{0} has {1} in the bank.", name, balance);
        return balance;
    }
}