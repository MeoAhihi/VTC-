//Input m, n
System.Console.Write("Please enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());
System.Console.Write("Please enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());

//Insisting for positive numbers
while ((firstNum <= 0) || (secondNum < firstNum)) {
    System.Console.Write("Please enter the first number again: ");
    firstNum = int.Parse(Console.ReadLine());
    System.Console.Write("Please enter the second number again: ");
    secondNum = int.Parse(Console.ReadLine());
}

//out
for (int i = firstNum; i <= secondNum; i++) {
    if (i % 7 == 0) System.Console.WriteLine(i);
}