var word = new char[10];

for (byte i = 0; i < word.Length; i++)
{
    System.Console.Write("Please enter your letter: word[{0}] = ", i);
    word[i] = char.Parse(Console.ReadLine());

    while ((word[i] < 'a') || (word[i] > 'z'))
    {
        System.Console.Write("That should not be a special character : word[{0}] = ", i);
        word[i] = char.Parse(Console.ReadLine());
    }
}

for (byte i = 0; i < word.Length; i++)
{
    word[i] = char.ToUpper(word[i]);
    System.Console.WriteLine("word[{0}] = {1}", i, word[i]);
}