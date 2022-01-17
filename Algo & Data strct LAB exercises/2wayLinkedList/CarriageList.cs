class CarriageList
{
    Carriage head = null;
    public void printCarriage()
    {
        Carriage pointer = head;
        while (pointer != null)
        {
            pointer.print();
            pointer = pointer.next;
        }
        System.Console.WriteLine("\\");
    }
    public void insertHead(string serial)
    {//LIST: |SE1|->
        var temp = new Carriage(serial); //TEMP: |SE2|->
        temp.next = head; //TEMP: |SE2|->|SE1|->
        head = temp; // HEAD: |SE2|->|SE1|->
    }
    public void insertTail(string serial)
    {
        if (head == null) head = new Carriage(serial);
        else
        {
            Carriage pointer = head;
            while (pointer.next != null) //run to the end
            {
                pointer = pointer.next;
            }
            pointer.next = new Carriage(serial); //insert the train
        }
    }
}