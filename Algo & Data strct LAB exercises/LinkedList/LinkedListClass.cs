class Node
{
    public int data;
    public Node next;
    public Node(int newData)
    {
        data = newData;
        next = null;
    }
    public void print()
    {
        if (next == null) System.Console.WriteLine("|{0}|", data);
        else
        {
            System.Console.Write("|{0}|->", data);
            next.print();
        }
    }
    public void addToEnd(int data)
    {
        if (next == null) next = new Node(data);
        else
        {
            next.addToEnd(data);
        }
    }
}
class LinkedList
{
    public Node head = null;
    public void print()
    {
        head.print();
    }
    public void insertHead(int newData)
    {
        var newNode = new Node(newData);
        if (head == null) head = newNode;
        else
        {
            newNode.next = head;
            head = newNode;
        }
    }
    public void insertTail(int newData)
    {
        var newNode = new Node(newData);
        if (head == null) head = newNode;
        else head.addToEnd(newData);
    }

}