using System;

class Program
{
    static void Main()
    {
      
        byte byteValue = 10;
        short shortValue = 20;
        int intValue = 42;
        long longValue = 100000L;
        float floatValue = 3.14f;
        double doubleValue = 6.28;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

       
        string intAsString = intValue.ToString();

      
        double stringAsDouble = Convert.ToDouble("3.14");

        
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        Console.WriteLine($"string (converted from int): {intAsString}");
        Console.WriteLine($"double (converted from string): {stringAsDouble}");
    }
}