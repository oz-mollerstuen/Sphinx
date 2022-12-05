using System;
using System.Collections.Generic;

namespace Models
{

  class Dictionaries
  {
    public static Dictionary<int, string> riddles = new Dictionary<int, string>() {
      {1,"A family has five sons, each of them has a sister. How many kids does a family have in total?"}, {2, "There are four oranges, and you take three. How many do you have?"}, {3, "When David was eight, his little brother Alex was half of his age. David is 30 now. How old is Alex?"}, {4, "What is the product if you multiply all numbers on a phone's dial pad?"}
    };

    public static Dictionary<int, int> answers = new Dictionary<int, int>() {
        {1, 6}, {2, 3}, {3, 26}, {4, 0}
    };

    static void Main()
    {
      int randRiddles = new Random().Next(0, 5);
      Console.WriteLine(riddles[randRiddles]);
      int userInputOne = int.Parse(Console.ReadLine());
      if (userInputOne == answers[randRiddles])
      {
        randomRiddle();
      }
      else
      {
        Console.WriteLine("The Sphinx Ate You Scumbag!!!!!");
      }
    }


    static void randomRiddle()
    {
      int randRiddles = new Random().Next(1, 4);
      Console.WriteLine(riddles[randRiddles]);
      int userInputOne = int.Parse(Console.ReadLine());
      if (userInputOne == answers[randRiddles])
      {
        randomRiddle();
      }
      else
      {
        Console.WriteLine("The Sphinx Ate You Scumbag!!!!!");
      }
    }
  }


}






// public class Riddles
// {
//   public string RiddleQuestion;
//   public string RiddleAnswers;
//   public Riddles(string questions, string answers)
//   {
//     RiddleQuestion = questions;
//     RiddleAnswers = answers;
//   }
// }






