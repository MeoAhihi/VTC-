using System.Collections;

int input(string saySthg)
{
    System.Console.Write(saySthg);
    return int.Parse(Console.ReadLine());
}

System.Console.Write(
"Demo cac thao tac tren ArrayList so nguyen Java\n" +
"=======================================\n" +
"1- khoi tao danh sach.\n" +
"2- them 1 phan tu vao danh sach.\n" +
"3- xoa 1 phan tu ra khoi danh sach.\n" +
"4- chen 1 phan tu vao danh sach.\n" +
"5- duyet danh sach.\n" +
"6- tim 1 phan tu.\n" +
"7- sap xep danh sach tang dan\n" +
"8- sap xep danh sach giam dan\n" +
"0- thoat chuong trinh\n" +
"=======================================\n"
);

bool loop = true;

int mode = -1; //not 0 to avoid unattempted end of program

while (mode != 1) {
    mode = input("You choose: ");
    if (mode == 0)
    {
        loop = false;
        System.Console.WriteLine("Good bye, hope to see you again.");
        break;
    }
    else if ((mode >= 2) & (mode <= 8))
    {
        System.Console.WriteLine("Error: List hasn't been declared!");
    }
    else if (mode != 1)
    {
        System.Console.WriteLine("Sorry, I didn't understand");
    }
}

var list = new ArrayList();
System.Console.WriteLine("List declared.");

while (loop)
{
    System.Console.Write("You choose: ");
    switch (Console.ReadLine())
    {
        case "1":
            list.Clear();
            System.Console.WriteLine("New list was declare.");
            break;
        case "2":
            list.Add(input("You want to add: "));
            break;
        case "3":
            list.RemoveAt(input("You want to delete element at index: "));
            break;
        case "4":
            int number = input("The number you want to insert: ");
            int index = input($"You want to insert {number} at: ");
            list.Insert(index, number);
            break;
        case "5":
            for (int i = 0; i < list.Count; i++) { System.Console.WriteLine(i + " " + list[i]); }
            break;
        case "6":
            int search = input("You want to search for: ");
            index = list.IndexOf(search);
            if (index != -1) { System.Console.WriteLine($"{search} appeared first at {index}"); }
            else { System.Console.WriteLine("Not Found!"); }
            break;
        case "7":
            list.Sort();
            System.Console.WriteLine("List has been sorted.");
            break;
        case "8":
            list.Sort();
            list.Reverse();
            System.Console.WriteLine("List has been decreasingly sorted.");
            break;
        case "0":
            System.Console.WriteLine("Bye bye!");
            loop = false;
            break;
        default:
            System.Console.WriteLine("Sorry, I didn't understand.");
            break;

    }
}