using System;

class Program
{
  static void Main()
  {
    PrintUsingfor();
    PrintUsingwhile();
    PrintUsingdowhile();
  }

  static void PrintUsingfor()
  {
    for (int i=1; i<=5; i++)
    {
      Console.WriteLine(i);
    }
  }
  static void PrintUsingwhile()
  {
    int i =6;
    while(i <= 10)
    {
      Console.WriteLine(i);
      i++;
    }
  }
  static void PrintUsingdowhile()
  {
    int i = 1;
    do
    {
      Console.WriteLine("");
      i++;
    }
    while (i <= 1)
    }
}
