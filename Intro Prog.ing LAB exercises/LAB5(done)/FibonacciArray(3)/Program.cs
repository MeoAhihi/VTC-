short[] fibonacci = new short[20];
fibonacci[0] = 1; fibonacci[1] = 1;

for (byte i = 2; i < fibonacci.Length; i++) fibonacci[i] = (short)(fibonacci[i-1] + fibonacci[i-2]);

for (byte i = 0; i < fibonacci.Length; i++) System.Console.WriteLine("fibonacci[{0}] = {1}", i, fibonacci[i]);