using System;
using System.Collections.Generic;
using Models;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("A family has five sons, each of them has a sister. How many kids does a family have in total?");
      string stringUserInputOne = Console.ReadLine();
      int userInputOne = int.Parse(stringUserInputOne);

      if (userInputOne == 6) 
      {
        Console.WriteLine("There are four oranges, and you take three. How many do you have?");
      } 
      else 
      {
        Console.WriteLine("The Sphinx Ate You Scumbag!!!!!");
      }
      string stringUserInputTwo = Console.ReadLine();
      int userInputTwo = int.Parse(stringUserInputTwo);

      if (userInputTwo == 3) 
      {
        Console.Write("When David was eight, his little brother Alex was half of his age. David is 30 now. How old is Alex?");
      }
      else 
      {
        Console.WriteLine("The Sphinx Ate You Scumbag!!!!!");
      }
      string stringUserInputThree = Console.ReadLine();
      int userInputThree = int.Parse(stringUserInputThree);

      if (userInputThree == 26)
      {
        Console.WriteLine("What is the product if you multiply all numbers on a phone's dial pad?");
      }
      else 
      {
        Console.WriteLine("The Sphinx Ate You Scumbag!!!!! ");
      }
      string stringUserInputFour = Console.ReadLine();
      int userInputFour = int.Parse(stringUserInputFour);







      // Riddles family = new Riddles("A family has five sons, each of them has a sister. How many kids does a family have in total?");
      // Riddles oranges = new Riddles("There are four oranges, and you take three. How many do you have?");
      // Riddles age = new Riddles("When David was eight, his little brother Alex was half of his age. David is 30 now. How old is Alex?");
      // Riddles phone = new Riddles("What is the product if you multiply all numbers on a phone's dial pad?");

      
      // List<Riddles> Riddle = new List<Riddles>() { family, oranges, age, phone };

      // foreach (Riddles newRiddle in Riddle)
      // {
      //   if(newRiddle == 6)
      //   {

      //   }
      // }










      // string[] riddleQuestions = { "A family has five sons, each of them has a sister. How many kids does a family have in total?", "There are four oranges, and you take three. How many do you have?", "When David was eight, his little brother Alex was half of his age. David is 30 now. How old is Alex?", "What is the product if you multiply all numbers on a phone's dial pad?" };
      // int[] riddleAnswers = { 6, 3, 26, 0 };

      // foreach (string questions in riddleQuestions)
      // {
      // }

      // foreach (int answers in riddleAnswers)
      // {

      // }



    }
  }
}




