var score = new float[5,6];
var rand = new Random();

for (byte i = 0; i < 5; i++) for (byte j = 0; j < 6; j++) score[i,j] = (float)rand.NextDouble()*10.0f;

/*
for (byte i = 0; i < 5; i++) {
    System.Console.WriteLine("Student {0}:", i + 1);
    System.Console.Write("CF score: "); score[i,0] = float.Parse(Console.ReadLine());
    System.Console.Write("C score: "); score[i,1] = float.Parse(Console.ReadLine());
    System.Console.Write("HDJ score: "); score[i,2] = float.Parse(Console.ReadLine());
    System.Console.Write("DU score: "); score[i,3] = float.Parse(Console.ReadLine());
    System.Console.Write("RDBMS score: "); score[i,4] = float.Parse(Console.ReadLine());
    System.Console.Write("Java score: "); score[i,5] = float.Parse(Console.ReadLine());
}
*/
for (byte i = 0; i < 5; i++) {
    System.Console.WriteLine("Student {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}", i + 1, score[i,0], score[i,1], score[i,2], score[i,3], score[i,4], score[i,5], (score[i,0] + score[i,1] + score[i,2] + score[i,3] + score[i,4] + score[i,5])/6 );
}