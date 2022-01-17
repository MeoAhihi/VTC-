System.Console.WriteLine("What's your string? ");
string input = Console.ReadLine().ToLower().Replace(" ","");

bool isPalindrome = true;
for (int i = 0, j = input.Length - 1; i < j; i++, j--) {
    if (input[i] != input[j]) {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome) System.Console.WriteLine($"{input} is palindrome.");
else {System.Console.WriteLine($"{input} is not palindrome.");}