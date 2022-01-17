class Carriage {
    public string seriNum;
    public Carriage next;
    public Carriage(string serial) {
        seriNum = serial;
        next = null;
    }
    public void print() {
        System.Console.Write($"({seriNum})->");
    }
}