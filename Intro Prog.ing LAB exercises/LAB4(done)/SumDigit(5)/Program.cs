System.Console.Write("Please enter a number: ");
string number = Console.ReadLine();
byte sum = 0; 
for (byte i = 0; i < number.Length; i++) sum += (byte)((number[i]) - '0'); 

System.Console.WriteLine("sum of all digits of {0} is {1}", number, sum);

