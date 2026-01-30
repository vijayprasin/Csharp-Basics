using System;

class StudentMarks
{
    // Method to get marks
    static int[] GetMarks()
    {
        int[] marks = new int[5];

        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write("Enter mark " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        return marks;
    }

    // Method to calculate total
    static int GetTotal(int[] marks)
    {
        int total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

        return total;
    }

    // Method to calculate average
    static double GetAverage(int total, int count)
    {
        return (double)total / count;
    }

    // Method to check result
    static void CheckResult(int[] marks)
    {
        foreach (int m in marks)
        {
            if (m < 35)
            {
                Console.WriteLine("Result: FAIL");
                return;
            }
        }
        Console.WriteLine("Result: PASS");
    }

    static void Main()
    {
        int[] marks = GetMarks();

        int total = GetTotal(marks);
        double avg = GetAverage(total, marks.Length);

        Console.WriteLine("Total = " + total);
        Console.WriteLine("Average = " + avg);

        CheckResult(marks);
    }
}
