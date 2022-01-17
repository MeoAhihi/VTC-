class TrainList
{
    public Train head = null;
    public void printTrain()
    {
        Train pointer = head;
        while (pointer != null)
        {
            pointer.printTrain();
            pointer = pointer.next;
        }
    }
    public void printTrainandCarriage()
    {
        Train pointer = head;
        while (pointer != null)
        {
            pointer.printTrain();
            pointer.printCarriages();
            System.Console.WriteLine(" |\n v");
            pointer = pointer.next;
        }
    }
    public void insertHead(string serial)
    {//LIST: |SE1|->
        Train temp = new Train(serial); //TEMP: |SE2|->
        temp.next = head; //TEMP: |SE2|->|SE1|->
        head = temp; // HEAD: |SE2|->|SE1|->
    }
    public void insertTail(string serial)
    {
        if (head == null) head = new Train(serial);
        else
        {
            Train pointer = head;
            while (pointer.next != null) //run to the end
            {
                pointer = pointer.next;
            }
            pointer.next = new Train(serial); //insert the train
        }
    }
    private Train Search(string serial)
    {
        Train pointer = head;
        while (pointer != null)
        {
            if (pointer.seriNum == serial) return pointer;
            pointer = pointer.next;
        }
        return null;
    }
    public void insertCarriage()
    {
        CarriageList tempList = new CarriageList();

        System.Console.WriteLine("Name/Serial number of the train: ");
        Train pointer = Search(Console.ReadLine());
        if (pointer != null)
        {
            bool loop = true;
            while (loop)
            {
                System.Console.Write(
                    "1- Add carriages to the head.\n" +
                    "2- Add carriages to the tail.\n" +
                    "other- Stop adding carriages.\n" +
                    "You choose: "
                );
                switch (Console.ReadLine())
                {
                    case "1":
                    headMode:
                        System.Console.Write("Serial number of the carriage you want to add: ");
                        tempList.insertHead(Console.ReadLine());
                        System.Console.Write("Press y to continue to add to head: ");
                        if (Console.ReadLine().ToLower() == "y") goto headMode;
                        break;
                    case "2":
                    tailMode:
                        System.Console.Write("Serial number of the carriage you want to add: ");
                        tempList.insertTail(Console.ReadLine());
                        System.Console.Write("Press y to continue to add to end: ");
                        if (Console.ReadLine().ToLower() == "y") goto tailMode;
                        break;
                    default: loop = false; break;
                }
            }
            pointer.listofCarriage = tempList;
        }
        else System.Console.WriteLine("No train was found");
    }

    public void Initialize()
    {
        head = null;
        System.Console.WriteLine("new list of Trains have been made.");
    }
    public void insertTrain()
    {
        bool loop = true;
        while (loop)
        {
            System.Console.Write(
                "1- Add trains to the head.\n" +
                "2- Add trains to the tail.\n" +
                "other- Stop adding trains.\n" +
                "You choose: "
            );
            switch (Console.ReadLine())
            {
                case "1":
                headMode:
                    System.Console.Write("Serial number of the train you want to add: ");
                    insertHead(Console.ReadLine());
                    System.Console.Write("Press y to continue to add to head: ");
                    if (Console.ReadLine().ToLower() == "y") goto headMode;
                    break;
                case "2":
                tailMode:
                    System.Console.Write("Serial number of the train you want to add: ");
                    insertTail(Console.ReadLine());
                    System.Console.Write("Press y to continue to add to end: ");
                    if (Console.ReadLine().ToLower() == "y") goto tailMode;
                    break;
                default: loop = false; break;
            }
        }

    }
}