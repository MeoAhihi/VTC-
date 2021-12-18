class Product
{
    private string product = "asdf";
    private byte quantity;
    private short price;
    private short totalPrice;

    public static void Title() {
        System.Console.WriteLine("DANH MUC SAN PHAM\n"+
        "==================================================\n"+
        "|STT|      Product      |Quantity|Price($)|Total Price($)|\n"+
        "==================================================");
    }

    public void input() {
        System.Console.Write("Please enter the product's name: ");
        product = Console.ReadLine();
        System.Console.Write("Please enter the its quantity: ");
        quantity = byte.Parse(Console.ReadLine());
        System.Console.Write("Please enter the its price: ");
        price = short.Parse(Console.ReadLine());
    }

    public void print(byte stt) {
        System.Console.WriteLine("| {0} |{1,19}|{2,8}|{3,8}|{4,14}|", stt, product, quantity, price, quantity*price);
    }
}