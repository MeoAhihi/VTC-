int[] array = new int[10];

System.Console.WriteLine("Please give the value for the array: ");
for (int i = 0; i < 10; i++) {
    System.Console.Write("array[{0}] = ", i);
    array[i] = int.Parse(Console.ReadLine());
}

System.Console.WriteLine("=============");

for (int i = 0; i < 10; i+=2) {
    System.Console.WriteLine("array[{0}] = {1}", i, array[i]);
}