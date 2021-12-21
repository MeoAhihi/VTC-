System.Console.Write("Please enter a string: ");
string input = "VI phong DEp       tRai".Trim();

string result = "";
bool goodSpace = true, goodUpper = true;

for (int i = 0; i < input.Length; i++)
{

    if ((input[i] == ' ')&&(goodSpace))
    {
        result += " ";
        goodSpace = false;
        goodUpper = true;
    }

    else if ((char.ToLower(input[i]) >= 'a') || (char.ToLower(input[i]) <= 'z'))
    {
        if (goodUpper)
        {
            result += char.ToUpper(input[i]);
            goodUpper = false;
        }
        else
        {
            result += char.ToLower(input[i]);
        }
        goodSpace = true;
    }
}

System.Console.WriteLine(result);