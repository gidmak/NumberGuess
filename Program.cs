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
            
            Console.WriteLine("Choose difficulty level...");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("Press a number to begin...");

            GetLevel();    
        }

        private static void GetLevel()
        {
            int level = 0;
            try
            {
                level = int.Parse(Console.ReadLine());
                if(level == 1)
                {
                    Easy();
                }
                else if(level == 2)
                {
                    Medium();
                }
                else
                {
                    Hard();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("You did not enter a valid level");
            }
        }
        private static void Easy()
        {
            Console.WriteLine("EASY");
            Console.WriteLine("Enter a random number from 1 to  10. You have up to 6 trials....");
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
                
        private static void Medium()
        {
            Console.WriteLine("MEDIUM");
            Console.WriteLine("Enter a random number from 1 to  20. You have up to 4 trials....");
            int secret = new Random().Next(1,20);

            int allowedTry = 4;
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
        
        private static  void Hard()
        {
            Console.WriteLine("HARD");
            Console.WriteLine("Enter a random number from 1 to  50. You have up to 3 trials....");
            int secret = new Random().Next(1,50);

            int allowedTry = 3;
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
                    Console.Write("Too low ");
                }
                if(guess > secret)
                {
                    Console.Write("Too high ");
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
