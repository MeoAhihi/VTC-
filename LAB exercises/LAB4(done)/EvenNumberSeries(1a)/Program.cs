System.Console.Write("Please enter your positive number: ");
float number = float.Parse(Console.ReadLine());

while(number < 0) {
    System.Console.Write("Don't be so negative. Be happy! Give me another number: ");
    number = float.Parse(Console.ReadLine());
}

System.Console.WriteLine("Series of even number not grater than {0} is: ", number);
for (ushort i = 0; i <= number; i+=2) System.Console.WriteLine(i);