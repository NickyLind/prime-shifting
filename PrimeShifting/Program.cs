using System;
using System.Collections.Generic;
using System.Linq;


namespace Program
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a number to return every prime up to that number");
      int userNumber = int.Parse(Console.ReadLine());
      List <int> userNumberList = new List<int> {}; 
      for (int i = 2; i < userNumber; i ++)
      {
        userNumberList.Add(i);
      }
      for (int i = 2; i <= Math.Round(Math.Sqrt(userNumber)); i++)
      {
        foreach(int number in userNumberList.ToList())
        {
        if (number % i == 0)
          userNumberList.Remove(number);
        }
      }
      Console.WriteLine($"2, 3, {string.Join( ", ", userNumberList)}");
    }
  }
}