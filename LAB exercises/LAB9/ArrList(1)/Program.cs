using System.Collections;

var list = new ArrayList();

int input()
{
    return int.Parse(Console.ReadLine());
}

System.Console.Write(
"Demo cac thao tac tren ArrayList so nguyen Java\n"+
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
while (loop)
{
    System.Console.Write("You choose: ");
    switch (Console.ReadLine())
    {
        case "2":
            System.Console.Write("You want to add: ");
            list.Add(input());
            break;
        case "3":
            System.Console.Write("You want to delete element at index: ");
            list.RemoveAt(input());
            break;
        case "4":
            System.Console.Write("The number you want to insert: ");
            int number = input();
            System.Console.Write($"You want to insert {number} at: ");
            int index = input();
            list.Insert(index, number);
            break;
        case "5":
            for (int i = 0; i < list.Count; i++) { System.Console.WriteLine(i + " " + list[i]); }
            break;
        case "6":
            System.Console.Write("You want to search for: ");
            int search = input();
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
            System.Console.WriteLine("Sorry, I don't understand.");
            break;

    }
}