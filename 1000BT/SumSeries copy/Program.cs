long SumN(uint n)
{
    //if ((n == 0) || (n == 1)) return n;
    //else return n + SumN(n - 1);
    return ((n == 0) || (n == 1) ? n : n + SumN(n - 1));
}

long SumN2(uint n)
{
    //if ((n == 0) || (n == 1)) return n;
    //else return n*n + SumN2(n - 1);
    return ((n == 0) || (n == 1) ? n : n * n + SumN2(n - 1));
}

double SumInverseN(uint n)
{
    //if (n == 1) return 1;
    //else return 1/n + SumInverseN(n - 1);
    return (n == 1 ? 1 : 1.0 / n + SumInverseN(n - 1));
}

double SumInverseOdd(uint n)
{
    //if (n == 1) return 1;
    //else return 1f/(2*n+1) + SumN(n - 1);
    return (n == 1 ? 1 : 1.0 / (2 * n + 1) + SumInverseOdd(n - 1));
}

double SumInverseProduct(uint n)
{
    //if (n == 1) return 1f/2;
    //else return 1f/(2*n+1) + SumN(n - 1);
    return (n == 1 ? 0.5 : 1.0 / (n * (n + 1)) + SumInverseProduct(n - 1));
}

double SumDivision(uint n)
{
    //if (n == 1) return 0.5;
    //else return (double)n / (n + 1);
    return (n == 1 ? 0.5 : (double)n / (n + 1) + SumDivision(n - 1));
}

double SumDivisionNoOverlap(uint n)
{
    return (n == 1 ? 3.0 / 4 : ((double)n * 2 + 1) / (2 * n + 2) + SumDivisionNoOverlap(n - 1));
}

long Factorial(uint n)
{
    return ((n == 0) || (n == 1) ? 1 : n * Factorial(n - 1));
}

double Power(float x, uint n)
{
    return (n == 0 ? 1 : x * Power(x, n - 1));
}

long SumFact(uint n)
{
    return (n == 1 ? 1 : Factorial(n) + SumFact(n - 1));
}

double SumPower(float x, uint n)
{
    return ((n == 0) || (n == 1) ? 1 : Power(x, n) + SumPower(x, n - 1));
}

double SumEvenPower(float x, uint n)
{
    x *= x; // x^2
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i); // (x^2)^i
    return sum;
}

double SumOddPower(float x, uint n)
{
    float x2 = x * x; //x^2
    double sum = 0;
    for (uint i = 0; i <= n; i++) sum += Power(x2, i) * x; //x^(2i+1) =(x^2)i * x
    return sum;
}

double SumIverseSumN(uint n)
{
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += 1.0 / SumN(i);
    return sum;
}

double SumXNOverSumN(float x, uint n)
{
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i) / SumN(i);
    return sum;
}

double SumXNOverFact(float x, uint n)
{
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i) / Factorial(i);
    return sum;
}

double SumEvenPowerOverFact(float x, uint n)
{
    double sum = 0;
    for (uint i = 0; i <= 2 * n; i += 2) sum += Power(x, i) / Factorial(i);
    return sum;
}

double SumOddPowerOverFact(float x, uint n)
{
    double sum = 0;
    for (uint i = 1; i <= 2 * n + 1; i += 2) sum += Power(x, i) / Factorial(i);
    return sum;
}

System.Console.WriteLine(SumN(6));