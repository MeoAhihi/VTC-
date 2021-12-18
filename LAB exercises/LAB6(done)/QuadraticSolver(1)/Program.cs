float A = 0, B = 0, C = 0;
System.Console.WriteLine("Please enter the coefficient of <Ax^2 + Bx + C = 0>:");
enterParameters(ref A, ref B, ref C);
QuadraticSolver(A, B, C);

void QuadraticSolver(float A, float B, float C)
{
    if (A == 0) { System.Console.WriteLine("This is not a quadratic equation"); }
    else
    {
        System.Console.Write("{0}x^2 + {1}x + {2} = 0 => ", A, B, C);
        float delta = B * B - 4 * A * C;
        if (delta > 0) {TwoSolutions(A, B, delta);}
        else if (delta == 0) {OneSolution(A, B);}
        else {NoSolution();}
    }
}

void enterParameters(ref float a, ref float b, ref float c)
{
    System.Console.Write("A = ");
    a = float.Parse(Console.ReadLine());

    System.Console.Write("B = ");
    b = float.Parse(Console.ReadLine());

    System.Console.Write("C = ");
    c = float.Parse(Console.ReadLine());
}

void TwoSolutions(float a, float b, float delta) {
    float squareRootDelta = (float)Math.Sqrt(delta);

    System.Console.WriteLine("x = {0} or x = {1}", (-b - squareRootDelta)/(2*a), (-b + squareRootDelta)/(2*a));
}

void OneSolution(float a, float b) {
    System.Console.WriteLine("x = {0}", -b/(2*a));
}

void NoSolution() {
    System.Console.WriteLine("No real solution");
}