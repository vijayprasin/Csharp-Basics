using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter first number");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number");
    int b = Convert.ToInt32(Console.ReadLine());

    Add(a,b);
    Subtract(a,b);
    Multiply(a,b);
    Divide(a,b);
  }

  static void Add(int x, int y)
  {
    Console.WriteLine("Addition = " + (x + y));
  }
  static void Subtract(int x, int y)
  {
    Console.WriteLine("Subtraction = " + (x - y));
  }
  static void Multiply(int x, int y)
  {
    Console.WriteLine("Multiplication = " + (x * y));
  }
  static void Divide(int x, int y)
  {
    if (y != 0)
    Console.WriteLine("Division = " + (x / y));
    else
      Console.WriteLine("Cannot divide by zero");
  }
