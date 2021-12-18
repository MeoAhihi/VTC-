bool PerfectTest(uint number)
{
    uint sum = 0;
    for (uint i = 1; i < number; i++) if (number % i == 0) sum += i;

    return (number == sum);
}

var input = new uint[10];
for (uint i = 0; i < 10; i++)
{
    System.Console.Write("input[{0}] = ", i);
    input[i] = uint.Parse(Console.ReadLine());
}

System.Console.WriteLine("======================");
for (uint i = 0; i < 10; i++) if (PerfectTest(input[i])) System.Console.WriteLine("input[{0}] = {1}", i, input[i]);