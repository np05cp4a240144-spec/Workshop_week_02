using System;

class Program
{
    static void Main()
    {
       
        int[] numbers = { 7, 42, 15, 3, 25 };

      
        Array.Sort(numbers);

        Console.WriteLine("Array after sorting:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

     
        Array.Reverse(numbers);

        Console.WriteLine("\nArray after reversing:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        
        int searchNumber = 15;
        int position = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine($"\nPosition of {searchNumber}: {position}");
    }
}