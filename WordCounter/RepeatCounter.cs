using System;
using System.Collections.Generic;
using RepeatedWordCounter;

namespace RepeatedWordCounter
{
  public class RepeatCounter
  {
    // string UserInputSentence;
    // string UserInputWord;
    public static int total;
    public int UserSentence(string UserInputSentence, string UserInputWord)//This function will be finding the duplicates.
    {
    string[] inputSplit = UserInputSentence.Split(" ");

    for(int i = 0; i < inputSplit.Length; i++)
    {
      if (inputSplit[i] == UserInputWord)
      {
        total += 1;
      } 

       
    }
      return total;
    }
     
  }
}