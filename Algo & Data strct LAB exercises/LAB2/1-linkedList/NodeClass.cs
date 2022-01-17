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
    public void DeleteNumber(int number)
    {
        if (next != null)
        {
            if (next.data == number)
            {
                next = next.next;
                System.Console.WriteLine(number + " was deleted from list.");
            }
            else next.DeleteNumber(number);
        }
        else System.Console.WriteLine("No {0} was found to delete.", number);
    }
    public int max(int premax)
    {
        if (next == null) return premax;
        else if (premax > next.data) return premax;
        else return next.data;
    }
}