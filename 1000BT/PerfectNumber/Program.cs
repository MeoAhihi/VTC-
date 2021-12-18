bool PerfectTest(uint number)
{
    uint sum = 0;
    for (uint i = 1; i < number; i++) if (number % i == 0) sum += i;

    if (number == sum) return true;
    else return false;
}

bool PrimeTest(uint number) {
    
    bool isPrime = true;
    for (uint i = 2; i < number; i++) {
        if (number % i == 0) {
            isPrime = false;
            break;
        }
    }

    return isPrime;
}

