long SumN(uint n) {
    long sum = 0; 
    for (uint i = 1; i <= n; i++) sum += i;
    return sum;
}

long SumN2(uint n) {
    long sum = 0;
    for (uint i = 1; i <= n; i++) sum += i*i;
    return sum;
}

double SumInverseN(uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += 1.0/i;
    return sum;
}

double SumInverseOdd(uint n) {
    double sum = 0;
    for (uint i = 0; i <= n; i++) sum += 1.0/(2 * i + 1);
    return sum;
}

double SumInverseProduct(uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += 1.0/(i * ( i + 1 ));
    return sum;
}

double SumDivision(uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += (double)i / (i + 1);
    return sum;
}

double SumDivisionNoOverlap(uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += (double)(2*i + 1) / (2*i + 2);
    return sum;
}

long Factorial(uint n) {
    long product = 1;
    for (uint i = 1; i <= n; i++) product *= i;
    return product;
}

double Power(float x, uint n) {
    double product = 1; //1*x*x*x
    for (uint i = 1; i <= n; i++) product *= x;
    return product;
}

long SumFact(uint n) {
    long sum = 0;
    for (uint i = 1; i <= n; i++) sum += Factorial(i);
    return sum;
}

double SumPower(float x, uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i);
    return sum;
}

double SumEvenPower(float x, uint n) {
    x *= x; // x^2
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i); // (x^2)^i
    return sum;
}

double SumOddPower(float x, uint n) {
    float x2 = x*x; //x^2
    double sum = 0;
    for (uint i = 0; i <= n; i++) sum += Power(x2, i)*x; //x^(2i+1) =(x^2)i * x
    return sum;
}

double SumIverseSumN(uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += 1.0 / SumN(i);
    return sum;
}

double SumXNOverSumN(float x, uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i) / SumN(i);
    return sum;
}

double SumXNOverFact(float x, uint n) {
    double sum = 0;
    for (uint i = 1; i <= n; i++) sum += Power(x, i) / Factorial(i);
    return sum;
}

double SumEvenPowerOverFact(float x, uint n) {
    double sum = 0;
    for (uint i = 0; i <= 2*n; i+=2) sum += Power(x, i) / Factorial(i);
    return sum;
}

double SumOddPowerOverFact(float x, uint n) {
    double sum = 0;
    for (uint i = 1; i <= 2*n + 1; i+=2) sum += Power(x, i) / Factorial(i);
    return sum;
}

System.Console.WriteLine(SumOddPowerOverFact(3, 4));