int[] aint = new int[10];
float[] afloat = new float[5];

System.Console.WriteLine("Please give the value for the float array: ");
for (byte i = 0; i < afloat.Length; i++) {
    System.Console.Write("afloat[{0}] = ", i);
    afloat[i] = float.Parse(Console.ReadLine());

    aint[2*i] = 0;
    aint[2*i+1] = (int)afloat[i];
}

System.Console.WriteLine("=========");

for (byte i = 0; i < aint.Length; i++) System.Console.WriteLine("aint[{0}] = {1}", i, aint[i]);