class Calculator
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }

    static int Mul(int a, int b)
    {
        return a * b;
    }

    static int Div(int a, int b)
    {
        return a / b;
    }

    static void Main()
    {
        Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter A: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
            Console.WriteLine(Add(a, b));
        else if (choice == 2)
            Console.WriteLine(Sub(a, b));
        else if (choice == 3)
            Console.WriteLine(Mul(a, b));
        else if (choice == 4)
            Console.WriteLine(Div(a, b));
        else
            Console.WriteLine("Invalid choice");
    }
}
