System.Console.Write("How many fibonacci number do you need? ");
byte N = Convert.ToByte(Console.ReadLine());
long presenter = 1, reminder1 = 0, reminder2 = 0;
for (byte i = 0; i < N; i++) {
    System.Console.WriteLine(presenter);
    reminder2 = reminder1;
    reminder1 = presenter;
    presenter = (reminder1 + reminder2);
}
System.Console.WriteLine("");