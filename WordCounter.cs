using System;
using System.Collections.Generic;
using RepeatedWordCounter;


namespace RepeatedWordCounterUI
{
  public class RepeatCounterUI
  {
      public static void Main()
      {
         Console.WriteLine("Enter A sentence");
         string UserInputSentence = Console.ReadLine();

         Console.WriteLine("Enter a word");
         string UserInputWord = Console.ReadLine();
         RepeatCounter newRepeatCounter = new RepeatCounter();
         int result = newRepeatCounter.UserSentence(UserInputSentence, UserInputWord); 
         Console.WriteLine(result);

  }
 }
}