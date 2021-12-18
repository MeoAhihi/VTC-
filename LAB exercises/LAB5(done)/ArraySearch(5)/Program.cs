byte[] data = { 25, 96, 255, 100, 20, 8, 96, 69, 28, 04 };

System.Console.Write("What do you want to search? ");
byte searcher = byte.Parse(Console.ReadLine());

byte count = 0;
for (byte i = 0; i < data.Length; i++)
{
    if (data[i] == searcher) {
        if (count == 0) System.Console.WriteLine("{0} appeared first at position {1}", searcher, i);
        count++;
    }
}

if (count == 0) System.Console.WriteLine("{0} is not present in data", searcher);
else {System.Console.WriteLine("{0} appeared {1} time(s)", searcher, count);}