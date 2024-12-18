using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "one two three four five";
        string reversedString = string.Join(" ", inputString
            .Split(' ')
            .Select(x => new string(x.Reverse().ToArray())));
        
        Console.WriteLine(reversedString);
    }
}
