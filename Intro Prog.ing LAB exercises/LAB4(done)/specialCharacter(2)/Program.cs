System.Console.Write("Please give me a character: ");
char character = (Console.ReadLine())[0];

if (((character >= '0')&&(character <= '9'))||((character >= 'a')&&(character <= 'z'))||((character >= 'A')&&(character <= 'Z'))) {
    System.Console.WriteLine(character + " la chu so");
} else {System.Console.WriteLine(character + " la ki hieu dac biet");}