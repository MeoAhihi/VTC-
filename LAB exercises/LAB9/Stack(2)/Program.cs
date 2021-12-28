using System.Collections;

int input(string saySthg)
{
    System.Console.Write(saySthg);
    return int.Parse(Console.ReadLine());
}

System.Console.WriteLine(
"Demo cac thao tac tren Stack so nguyen Java\n"+
"====================================\n"+
"1- khoi tao stack.\n"+
"2- them 1 phan tu vao stack.\n"+
"3- lay phan tu dau ra khoi stack.\n"+
"4- xem phan tu dau stack.\n"+
"5- duyet stack.\n"+
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
    else if ((mode >= 2) & (mode <= 5))
    {
        System.Console.WriteLine("Error: Stack hasn't been declared!");
    }
    else if (mode != 1)
    {
        System.Console.WriteLine("Sorry, I didn't understand");
    }
}

var stack = new Stack<int>();
System.Console.WriteLine("Stack declared.");

while (loop)
{
    System.Console.Write("You choose: ");
    switch (Console.ReadLine())
    {
        case "1":
            stack.Clear();
            System.Console.WriteLine("New stack was declare.");
            break;
        case "2":
            stack.Push(input("You want to push: "));
            break;
        case "3":
            System.Console.WriteLine(stack.Pop() + " was removed from the top of stack.");
            break;
        case "4":
            System.Console.WriteLine("First element of stack is " + stack.Peek());
            break;
        case "5":
            System.Console.WriteLine("Stack: ");
            foreach (int element in stack) {
                System.Console.WriteLine(element);
            }
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