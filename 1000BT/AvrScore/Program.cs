float AvrScore(float math, float liturature, float english)
{
    return (2.0f * (math + liturature) + english) / 5.0f;
}

void InfoInput()
{
    System.Console.Write("What's your name? ");
    string name = Console.ReadLine();

    System.Console.Write("Math score: ");
    float Math = float.Parse(Console.ReadLine());

    System.Console.Write("Liturature score: ");
    float Liturature = float.Parse(Console.ReadLine());

    System.Console.Write("English score: ");
    float English = float.Parse(Console.ReadLine());

    float avrScore = AvrScore(Math, Liturature, English);
    System.Console.WriteLine("So {0}, your average score is {1}", name, avrScore);
}

InfoInput();