bool checkNumber(int N)
{
    bool isPrime = true;
    if (N <= 1) { isPrime = false; }
    else
    {
        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
    return isPrime;
}

var input = new int[10];
for (int i = 0; i < 10; i++)
{
    System.Console.Write("input[{0}] = ", i);
    input[i] = int.Parse(Console.ReadLine());
}

System.Console.WriteLine("======================");
for (int i = 0; i < 10; i++) if (checkNumber(input[i])) System.Console.WriteLine("input[{0}] = {1}", i, input[i]);