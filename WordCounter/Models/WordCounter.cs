using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static string _sentence; //property - user input to be searched
    private static string _word;

    public RepeatCounter(string sentence, string word) //constructor
    {
      _sentence = sentence; //to be searched
      _word = word;         //to be counted
    }

    // Methods
    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }
    public string GetWord()
    {
      return _word;
    }
    // public void SetWord(string newWord)
    // {
    //   _word = newWord;
    // }

  }
}
