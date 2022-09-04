//Let's play a game! Guess the number

using System;
using System.Linq;

class GuessTheNumber 
{
  
  public static void PlayGuess () 
  {
    
    int randomNum = new Random().Next(5, 30);
    int[] collectionOfGuesses = new int[5];

    static int InputGuess()
    {
      int userInput = 0;
      try
      {
        userInput = Convert.ToInt32(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Enter a valid number");
        userInput = InputGuess();
      }
      return userInput;
    }

    int availableTries = 5;
    int triesUsed = 0;

    while (true)
    {   
      int userInput = InputGuess();

      for (int i = 0; i < 5; i++)
      {
        if (!(collectionOfGuesses.Contains(userInput)))
          {
            collectionOfGuesses[i] = userInput;
             triesUsed++;
          }
      }

      if (userInput == randomNum)
        {
        Console.WriteLine("Your guess was correct!");
        break;
        }
      
        if (userInput > randomNum)
        {
            Console.WriteLine("Your guess was too high");
        }

        if (userInput < randomNum)
        {
            Console.WriteLine("Your guess was too low");
        }

        if (triesUsed == availableTries)
        {
            Console.WriteLine($"The number was: {randomNum}");
            break;
        }

        Console.Write($"You have {availableTries - triesUsed} tries left. Enter another number: ");
    }
        
     
 }
      
}