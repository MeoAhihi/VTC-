System.Console.Write("Please enter your number: ");
byte number = Convert.ToByte(Console.ReadLine());

while (number <= 1) {
    System.Console.Write("Please give me another number: ");
    number = Convert.ToByte(Console.ReadLine());
}

System.Console.WriteLine("This is the series of prime number not grater than {0} :", number);
for (byte i = 2; i <= number; i++) {
    bool isPrime = true;
    for (byte j = 2; j < i; j++) {
        if (i % j == 0) {
            isPrime = false;
            break;
        }
    }
    if (isPrime) System.Console.WriteLine(i);
}

