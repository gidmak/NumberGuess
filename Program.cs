using System.Linq.Expressions;
using System.Data;
using System.Security.Cryptography;
using System;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("= = = = = NUMBER GUESSING GAME = = = = =");
            
            GetLevel();    
        }

        private static void GetLevel()
        {
            int level = 0;
            try
            {
                level = int.Parse(Console.ReadLine());
                
                Easy();
              
            }
            catch(Exception)
            {
                Console.WriteLine("You did not enter a valid level");
            }
        }
        private static void Easy()
        {
            Console.WriteLine("EASY");
            Console.WriteLine("Choose a random number from 1 to  10. You have up to 6 trials....");
            int secret = new Random().Next(1,10);

            int allowedTry = 6;
            int noOfTry = 0;
            
            while(true)
            {
                int guess = int.Parse(Console.ReadLine());
                noOfTry++;
                if(guess == secret)
                {
                    Console.Write("Congratulations. You made it in " + noOfTry + " trials");
                    break;
                }
                if(guess < secret)
                {
                    Console.Write("Too low");
                }
                if(guess > secret)
                {
                    Console.Write("Too high");
                }
                if(noOfTry == allowedTry)
                {
                    Console.Write($"The number was: {secret}");
                    break;
                }
                Console.WriteLine($" You have {allowedTry - noOfTry} tries left. Enter another number: ");
            }
        }
                
       
    }
}
