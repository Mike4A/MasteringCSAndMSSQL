// Simple lambda expression
Func<int, int> square = x => x * x;
Console.WriteLine("Square: " + square(5));

// Lambda expression with multiple parameters
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine("Add: " + add(3, 4));

// Lambda expression with statement body
Func<int, string> getGrade = score =>
{
    if (score >= 90) return "A";
    if (score >= 80) return "B";
    if (score >= 70) return "C";
    return "F";
};
Console.WriteLine("Grade: " + getGrade(85));