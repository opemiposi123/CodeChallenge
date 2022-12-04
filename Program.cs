using System;

namespace CodeChallenge
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            Console.Write("Enter your word : ");
            string word = Console.ReadLine();
            if (word.Length > 10)
            {
                exercise.Swapping(word);
                return;
            }
           
        }
    }
}




