using System.Collections;

int input(string saySthg)
{
    System.Console.Write(saySthg);
    return int.Parse(Console.ReadLine());
}

System.Console.WriteLine(
"Chuong trinh quan ly danh sách sản phẩm SHOP ABC\n"+
"================================================\n"+
"1- khoi tao danh sach\n"+
"2- them 1 san pham vao danh sach\n"+
"3- xoa 1 san pham ra khoi danh sach\n"+
"4- duyet danh sach\n"+
"5- tim thong san pham theo ten\n"+
"6- tim thong tin san pham theo gia\n"+
"7- tim thong tin san pham theo khoang gia\n"+
"8- sap xep danh sach giam dan theo gia ban\n"+
"0- thoat chuong trinh"
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
            System.Console.WriteLine("A new product have been added!\nPlease enter its infomation:");
            list.Add(new Product());
            break;
        case "3":
            
        case "4":
            foreach (Product product in list)
            {
                product.print();
            }
            break;
        case "5":
            System.Console.Write("Studnet look up. Please enter his/her name: ");
            string search = Console.ReadLine();
            uint index = 0;
            foreach (Product obj in list)
            {
                if (obj.get_name() == search)
                {
                    obj.print();
                }
            }
            break;/*
        case "a":
            System.Console.Write("Product code: ");
            string code = Console.ReadLine();
            foreach (Product obj in list)
            {
                if (obj.get_name() == code)
                {
                    System.Console.Write("Product: {0} ({1}) has mark change to: ", obj.get_name(), obj.get_code());
                    obj.set_mark(float.Parse(Console.ReadLine()));
                    break;
                }
            }
            break;
        case "6":
            System.Console.WriteLine("List of Product has sholarship:");
            foreach (Product Product in list) {
                if (Product.check_scholarship()) {System.Console.WriteLine($"{Product.get_name()} ({Product.get_code()})");}
            }
            break;
        case "7":
            System.Console.Write("Product code: ");
            code = Console.ReadLine();
            foreach (Product obj in list)
            {
                if (obj.get_code() == code)
                {
                    System.Console.Write("Product: {0} ({1}) has mark: {2}", obj.get_name(), obj.get_code(), obj.get_mark());
                    break;
                }
            }
            break;
        case "8":
            list.Sort();
            break;
        case "0":
            System.Console.WriteLine("Bye bye!");
            loop = false;
            break;
        default:
            System.Console.WriteLine("Sorry, I didn't understand.");
            break;*/

    }
}