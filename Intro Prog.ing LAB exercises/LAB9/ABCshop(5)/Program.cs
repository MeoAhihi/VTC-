using System.Collections;

int input(string saySthg)
{
    System.Console.Write(saySthg);
    return int.Parse(Console.ReadLine());
}

System.Console.WriteLine(
"Chuong trinh quan ly danh sách sản phẩm SHOP ABC\n" +
"================================================\n" +
"1- khoi tao danh sach\n" +
"2- them 1 san pham vao danh sach\n" +
"3- xoa 1 san pham ra khoi danh sach\n" +
"4- duyet danh sach\n" +
"5- tim thong san pham theo ten\n" +
"6- tim thong tin san pham theo gia\n" +
"7- tim thong tin san pham theo khoang gia\n" +
"8- sap xep danh sach giam dan theo gia ban\n" +
"0- thoat chuong trinh"
);

bool loop = true;

int mode = -1; //not 0 to avoid unattempted end of program

while (mode != 1)
{
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
            System.Console.WriteLine("A new product have been added!\nPlease enter its infomation:");
            list.Add(new Product());
            break;
        case "3":
            list.RemoveAt(input("You want to delete product at index: "));
            break;
        case "4":
            foreach (Product product in list)
            {
                product.print();
            }
            break;
        case "5":
            System.Console.Write("Product look up. Please enter product's name: ");
            string search = Console.ReadLine();
            int index = -1;
            foreach (Product p in list)
            {
                if (p.get_name() == search)
                {
                    p.print();
                }
            }
            break;
        case "6":
            System.Console.Write("Product look up. Please enter product's price: ");
            int price = input("");
            index = -1;
            foreach (Product p in list)
            {
                if (p.get_price() == price)
                {
                    p.print();
                }
            }
            break;
        case "7":
            System.Console.WriteLine("Product look up. Please enter product's range of price: ");
            int min = input("Min price: ");
            int max = input("Max price: ");
            index = -1;
            foreach (Product p in list)
            {
                if ((p.get_price() >= min)&&(p.get_price() <= max))
                {
                    p.print();
                }
            }
            break;
        case "8":
            list.Sort();
            System.Console.WriteLine("List of products sorted.");
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