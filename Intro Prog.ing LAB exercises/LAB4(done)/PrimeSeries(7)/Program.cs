System.Console.Write("Please enter your number: ");
byte N = Convert.ToByte(Console.ReadLine());
byte count = 0; int number = 2;

while (count < N) {
    if (isPrime(number)) {
        System.Console.WriteLine(number);
        count++;
    }
    number++;
}

bool isPrime(int number) { 
    bool isPrime = true;
    for (int j = 2; j < number; j++) {
        if (number % j == 0) {
            isPrime = false;
            break;
        }
    }
    return isPrime;
}