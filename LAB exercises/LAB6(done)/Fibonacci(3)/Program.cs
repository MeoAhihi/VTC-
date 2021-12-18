long Fibo(int N)
{
    long presenter = 1, reminder1 = 0, reminder2 = 0;
    for (byte i = 1; i < N; i++)
    {
        reminder2 = reminder1;
        reminder1 = presenter;
        presenter = (reminder1 + reminder2);
    }
    return presenter;
}

for (int i = 1; i <= 5; i++) {
    System.Console.WriteLine(Fibo(i));
}