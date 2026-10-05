using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> fruits = new List<string>
        {
            "Apple",
            "Mango",
            "Banana"
        };

        
        fruits.Add("Orange");

      
        fruits.Remove("Banana");

      
        Console.WriteLine("Fruits in the List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary<int, string>
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

     
        fruitDictionary.Add(4, "Orange");

      
        Console.WriteLine("\nFruits in the Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}