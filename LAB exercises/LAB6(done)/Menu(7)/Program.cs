MenuPrinter();
Option();

void MenuPrinter()
{
    System.Console.WriteLine("+----------------------------+");
    System.Console.WriteLine("|            MENU            |");
    System.Console.WriteLine("+----------------------------+");
    System.Console.WriteLine("|1.Drink                     |");
    System.Console.WriteLine("|2.Food                      |");
    System.Console.WriteLine("|3.Game                      |");
    System.Console.WriteLine("|4.Gerbera                   |");
    System.Console.WriteLine("|5.Exit                      |");
    System.Console.WriteLine("+----------------------------+");
}

void Option()
{
    string choose;
    do
    {
        System.Console.Write("\nChoose: ");
        choose = Console.ReadLine();
        switch (choose)
        {
            case "1": System.Console.WriteLine("You want some drinks.\nAnything else?"); break;
            case "2": System.Console.WriteLine("You need some food.\nAnything else?"); break;
            case "3": System.Console.WriteLine("You want to play game.\nAnything else?"); break;
            case "4": System.Console.WriteLine("You want a Gerbera.\nAnything else?"); break;
            case "5": System.Console.WriteLine("Bye bye"); break;
            default: System.Console.WriteLine("I don't understand.\nPlease choose again."); break;
        }
    } while (choose != "5");
}