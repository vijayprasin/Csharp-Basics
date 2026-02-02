using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of words: ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter word " + (i + 1) + ": ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Reversed Words ---");
        ReverseWords(words);

        Console.WriteLine("\n--- Palindrome Words ---");
        PrintPalindromes(words);

        Console.WriteLine("\n--- Longest Word ---");
        FindLongestWord(words);
    }

    // Method 1: Reverse each string
    static void ReverseWords(string[] arr)
    {
        foreach (string word in arr)
        {
            char[] ch = word.ToCharArray();
            Array.Reverse(ch);
            Console.WriteLine(new string(ch));
        }
    }

    // Method 2: Print palindrome strings
    static void PrintPalindromes(string[] arr)
    {
        foreach (string word in arr)
        {
            string rev = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }

            if (word == rev)
                Console.WriteLine(word);
        }
    }

    // Method 3: Find longest string
    static void FindLongestWord(string[] arr)
    {
        string longest = arr[0];

        foreach (string word in arr)
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine("Longest word is: " + longest);
    }
}
