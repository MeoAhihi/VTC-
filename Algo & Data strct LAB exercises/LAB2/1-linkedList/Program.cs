LinkedList list = new LinkedList();

System.Console.WriteLine(
    "1- Making a list\n" +
    "2- Traversing the list\n" +
    "3- Add a number into list\n" +
    "4- Delete the first number of list\n" +
    "5- Delete a number from list\n" +
    "6- Search for a number\n" +
    "7- Search for maximum number\n" +
    "other - Exit"
);

bool loop = true;
while (loop)
{
    System.Console.Write("You choose: ");
    switch (Console.ReadLine())
    {
        case "1":
            list.Initialize();
            list.insertHead(1);
            list.insertHead(2);
            list.insertTail(8); break;

        case "2": list.Print(); break;

        case "3": list.Add(); break;

        case "4": list.DeleteHead(); break;

        case "5": list.DeleteByChoose(); break;

        case "6": list.Search(); break;

        case "7": list.Max(); break;

        default:
            System.Console.WriteLine("Bye bye!");
            loop = false;
            break;
    }
}