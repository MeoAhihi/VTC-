int[] array = new int[10];
System.Console.WriteLine("Please give the value for the array: ");
for (int i = 0; i < 10; i++) {
    System.Console.Write("array[{0}] = ", i);
    array[i] = int.Parse(Console.ReadLine());
}

int max = array[0], min = array[0], fmax = 0, fmin = 0;

foreach (int i in array) {
    if (max < i) {
        max = i;
        fmax = 1;
    } else if (max == i) fmax++;

    if (min > i) {
        min = i;
        fmin = 1;
    } else if (min == i) fmin++;
}

System.Console.WriteLine("{0} is max and repeated {1} time(s)\n{2} is min and repeated {3} time(s)",max, fmax, min, fmin);