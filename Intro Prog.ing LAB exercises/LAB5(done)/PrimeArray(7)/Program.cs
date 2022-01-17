bool isPrime(int number)
{
    bool isPrime = true;
    if (number < 2) isPrime = false;
    else for (int j = 2; j < number; j++)
        {
            if (number % j == 0)
            {
                isPrime = false;
                break;
            }
        }
    return isPrime;
}

var array = new int[5];

for (byte i = 0; i < array.Length; i++)
{
    System.Console.Write("Please enter your prime number: array[{0}] = ", i);
    array[i] = int.Parse(Console.ReadLine());

    while (!isPrime(array[i]))
    {
        System.Console.Write("That wasn't a prime number: array[{0}] = ", i);
        array[i] = int.Parse(Console.ReadLine());
    }
}

foreach (int i in array)
{
    System.Console.WriteLine(i);
}