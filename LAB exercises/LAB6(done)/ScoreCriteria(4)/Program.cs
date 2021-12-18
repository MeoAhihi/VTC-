char Classify(float score) {
    char result;
    if ((score <= 10)&&(score >= 8.5)) {result = 'A';}
    else if (score >= 7) {result = 'B';}
    else if (score >= 5.5) {result = 'C';}
    else if (score >= 4) {result = 'D';}
    else if (score >= 0) {result = 'F';}
    else {result = 'E';}
    return result;
}

System.Console.WriteLine("9.6 = " + Classify(9.6f));