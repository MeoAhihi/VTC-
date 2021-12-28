class Product {
    private string name;
    private string description;
    private uint price;

    public Product() {
        System.Console.Write("Product's name: "); name = Console.ReadLine();
        System.Console.Write(name + "'s descript: "); description = Console.ReadLine();
        System.Console.Write(name + "'s price: "); price = uint.Parse(Console.ReadLine());
    }
    public Product(string name, string description, uint price) {
        this.name = name;
        this.description= description;
        this.price = price;
    }
    public void print() {
        System.Console.WriteLine(
            "=======================\n"+
            "Name: {0}\n"+
            "Description: {1}\n"+
            "Price: {2}VND",
            name, description, price
        );
    }
    public string get_name() {return name;}

    public string get_description() {return description;}

    public uint get_price() {return price;}

    
}