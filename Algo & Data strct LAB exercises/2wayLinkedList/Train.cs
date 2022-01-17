class Train {
    public string seriNum;
    public CarriageList listofCarriage;
    public Train next;
    public Train(string serialNumber) {
        seriNum = serialNumber;
        next = null;
    }
    public void printTrain() {
        System.Console.Write($"|{seriNum}|->");
    }
    public void printCarriages() {
        if(listofCarriage == null) System.Console.WriteLine("\\");
        else listofCarriage.printCarriage();
    }
    public void insertCarriage() {
        System.Console.WriteLine("Serial number of the carriage: ");
        string serial = Console.ReadLine();
        System.Console.WriteLine(
            "1- Insert at the head\n"+
            "2- Insert at the end\n"+
            "You choose: "
        );
        switch (Console.ReadLine()) {
            case "1": listofCarriage.insertHead(serial); break;
            case "2": listofCarriage.insertTail(serial); break;
            default: System.Console.WriteLine("Sorry, I didn't understand!"); break;
        }
    }
}