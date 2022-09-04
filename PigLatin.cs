using System;
using System.Collections.Generic;

class PigLatin {
  public static void TranslateToPigLatin () {
    
      string sentenceInEnglish = Console.ReadLine(); 
      string[] splitSentence = sentenceInEnglish.Split(' ');
      List<string> splitEnglishSentence = new List<string>();

    foreach(string word in splitSentence){
        
            string firstLetter = word[0] + "ay";
            string restOfWord = word.Substring(1);

            splitEnglishSentence.Add(restOfWord + firstLetter);         
        }    

   
    Console.WriteLine(String.Join(" ", splitEnglishSentence));
    
    }
  
}