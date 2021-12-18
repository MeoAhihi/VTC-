var rand = new Random();
var multipler = new byte[20];
rand.NextBytes(multipler);

System.Console.Write("Please give me your number: ");
byte divisor = byte.Parse(Console.ReadLine());

foreach (byte item in multipler) if (item % divisor == 0) System.Console.WriteLine(item);