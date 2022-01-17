using System.Collections;

int input(string saySthg)
{
    System.Console.Write(saySthg);
    return int.Parse(Console.ReadLine());
}

System.Console.WriteLine(
"Demo cac thao tac tren Queue so nguyen Java\n"+
"=====================================\n"+
"1- khoi tao queue.\n"+
"2- them 1 phan tu vao queue.\n"+
"3- lay phan tu dau ra khoi queue.\n"+
"4- xem phan tu dau queue.\n"+
"5- duyet queue.\n"+
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
        System.Console.WriteLine("Error: queue hasn't been declared!");
    }
    else if (mode != 1)
    {
        System.Console.WriteLine("Sorry, I didn't understand");
    }
}

var queue = new Queue<int>();
System.Console.WriteLine("Queue declared.");

while (loop)
{
    System.Console.Write("You choose: ");
    switch (Console.ReadLine())
    {
        case "1":
            queue.Clear();
            System.Console.WriteLine("New queue was declare.");
            break;
        case "2":
            queue.Enqueue(input("You want to add: "));
            break;
        case "3":
            System.Console.WriteLine(queue.Dequeue() + " was removed from the top of queue.");
            break;
        case "4":
            System.Console.WriteLine("First element of queue is " + queue.Peek());
            break;
        case "5":
            System.Console.WriteLine("Queue: ");
            foreach (int element in queue) {
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