System.Console.Write("Please enter a string: ");
string input = Console.ReadLine();

System.Console.WriteLine("Character: " + input.Replace(" ", "").Length);

int vowel = 0, consonant = 0;
for (int i = 0; i < input.Length; i++) {
    if (input[i] != ' ') {
        if ((input[i] == 'a')||(input[i] == 'i')||(input[i] == 'u')||(input[i] == 'e')||(input[i] == 'o')) { vowel++;}
        else {consonant++;}
    }
}
System.Console.WriteLine($"Wowel: {vowel}, consonant: {consonant}");

System.Console.WriteLine("Words: " + input.Split(' ').Length);
