using Exc_Delegates;

MathOperation operation = Calculator.Add;
Console.WriteLine("Add: " + operation(5, 3));

operation = Calculator.Subtract;
Console.WriteLine("Subtract: " + operation(5, 3));

