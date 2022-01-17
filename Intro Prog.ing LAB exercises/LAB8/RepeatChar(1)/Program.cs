System.Console.Write("Please enter a string: ");
string input = Console.ReadLine();
System.Console.Write("What do you wanna find? ");
char find = Console.ReadLine()[0];

int repeat = 0;
foreach (var character in input) {
    if (character == find) repeat++;
}

System.Console.WriteLine($"There are {repeat} \"{find}\" in \"{input}\".");