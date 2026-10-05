using System;

class Program
{
    static void Main()
    {
      
        DateTime birthDate = new DateTime(2000, 5, 15);

       
        DateTime currentDate = DateTime.Now;

       
        TimeSpan ageDifference = currentDate - birthDate;

      
        int age = (int)(ageDifference.TotalDays / 365.25);

      
        Console.WriteLine($"Birthdate: {birthDate:dd/MM/yyyy}");
        Console.WriteLine($"Current Date: {currentDate:dd/MM/yyyy HH:mm:ss}");
        Console.WriteLine($"Age: {age} years");

     
        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate + 10 days: {newDate:dd/MM/yyyy}");
    }
}