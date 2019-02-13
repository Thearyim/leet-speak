using System;
using System.Collections.Generic;

namespace LeetSpeak
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter text to have it transformed into LeetSpeak: ");
      string userText = Console.ReadLine();
      LeetSpeak leetSpeak = new LeetSpeak();
      string result = leetSpeak.GetLeetSpeak(userText);
      Console.WriteLine("LeetSpeak: " + result);
    }
  }

}
