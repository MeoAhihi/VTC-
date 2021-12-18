//Insisting for a positive integer
System.Console.Write("Please give me your number: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0) {
    System.Console.Write("Don't be so negative. Give me another positive whole number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

//finding space, e.g: 5 = 101 = 0101 
byte length = (byte)(((byte)Math.Log2(number) / 4 + 1) * 4);

//displaying, spaceing for each 4 digit
while (length > 0) {
    int a = (int)Math.Pow(2,length-1);
    if (number >= a) {
        System.Console.Write("1");
        number -= a;
    } else {
        System.Console.Write("0");
    }
    length--;

    if (length % 4 == 0) System.Console.Write(" ");
}