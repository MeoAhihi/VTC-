int Power(int x, uint n) {
    int product = 1; 
    for (uint i = 1; i <= n; i++) product *= x;
    return product;
}
System.Console.WriteLine("Calculate x^m: ");
System.Console.Write("x = ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("m = ");
uint m = uint.Parse(Console.ReadLine());
System.Console.WriteLine("x^m = "+ Power(x, m));