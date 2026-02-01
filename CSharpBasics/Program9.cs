using System;

class StringArrayProgram
{
    // Method to get names
    static string[] GetNames()
    {
        string[] names = new string[5];

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write("Enter name " + (i + 1) + ": ");
            names[i] = Console.ReadLine();
        }

        return names;
    }

    // Method to print names
    static void PrintNames(string[] names)
    {
        Console.WriteLine("\nAll Names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    // Method to find longest name
    static string FindLongestName(string[] names)
    {
        string longest = names[0];

        foreach (string name in names)
        {
            if (name.Length > longest.Length)
                longest = name;
        }

        return longest;
    }

    // Method to print name lengths
    static void PrintNameLengths(string[] names)
    {
        Console.WriteLine("\nName Lengths:");
        foreach (string name in names)
        {
            Console.WriteLine(name + " -> " + name.Length);
        }
    }

    static void Main()
    {
        string[] names = GetNames();

        PrintNames(names);

        string longest = FindLongestName(names);
        Console.WriteLine("\nLongest Name: " + longest);

        PrintNameLengths(names);
    }
}
