bool PrimeTest(uint number) {
    
    bool isPrime = true;
    for (uint i = 2; i < number/2; i++) {
        if (number % i == 0) {
            isPrime = false;
            break;
        }
    }

    return isPrime;
}

void PrimeSeries(int N) {
    System.Console.WriteLine("Series of prime numbers smaller than " + N + " :");
    for (uint i = 2; i < N; i++) {
        if (PrimeTest(i)) System.Console.WriteLine(i);
    }
}

System.Console.Write("Please enter your limit number: ");
int number = int.Parse(Console.ReadLine());
PrimeSeries(number);