class LinkedList
{
    private const string Format = "There is no {0} in list";
    public Node head = null;
    public void Initialize()
    {
        head = null;
        System.Console.WriteLine("New list have been made!");
    }
    public void Print()
    {
        if (head == null) System.Console.WriteLine("The list is empty.");
        else head.print();
    }
    public void insertHead(int newData)
    {
        var temp = new Node(newData); //TEMP: |SE2|->
        temp.next = head; //TEMP: |SE2|->|SE1|->
        head = temp; // HEAD: |SE2|->|SE1|->

    }
    public void insertTail(int newData)
    {
        var newNode = new Node(newData);
        if (head == null) head = newNode;
        else head.addToEnd(newData);
    }
    public void Add()
    {
        System.Console.Write("You want to add: ");
        int number = int.Parse(Console.ReadLine());
        System.Console.Write(
            "1- Insert at head\n" +
            "2- Insert at tail\n" +
            "3- Insert in sorted way\n" +
            "You choose: "
        );
        switch (Console.ReadLine())
        {
            case "1": insertHead(number); break;
            case "2": insertTail(number); break;
            default: System.Console.WriteLine("I didn't understand"); break;
        }
    }
    public void DeleteHead()
    {
        if (head == null) System.Console.WriteLine("Empty list, nothing to delete.");
        else
        {
            head = head.next;
            System.Console.WriteLine("First number of list is deleted.");
        }
    }
    public void DeleteByChoose()
    {
        System.Console.Write("You want to delete: ");
        head.DeleteNumber(int.Parse(Console.ReadLine()));
    }
    public bool LookUp(Node temp, int search)
    {
        //return ((temp.data == search) || (temp == null) ? temp != null : LookUp(temp.next, search));
        if (temp.data == search) return true;
        else if (temp.next == null) return false;
        else return LookUp(temp.next, search);
    }
    public void Search()
    {
        System.Console.Write("You want to search for: ");
        int key = int.Parse(Console.ReadLine());
        if (LookUp(head, key)) System.Console.WriteLine("There is {0} in list.", key);
        else System.Console.WriteLine(Format, key);
    }
    public void Max()
    {
        System.Console.WriteLine("Max of the list: " + head.next.max(head.data));
    }

}

class LinkedListNoRecursion
{
    Node head = null;
    public void DeleteByChoose()
    {
        System.Console.Write("You want to delete: ");
        int number = int.Parse(Console.ReadLine());
        Node finder = head;
        while (finder != null)
        {
            if (finder.next.data == number)
            {
                finder.next = finder.next.next;
                break;
            }
            finder = finder.next;
        }
    }
}