using System;
using System.Collections.Generic;

namespace PeerGrade
{
    class Program
    {
        //This method generates a random number with a given lenght
        static void GenerateNumber(int numberOfDigits, out int number, out int[] digits)
        {
            //initiation of the random object
            Random rand = new Random();

            digits = new int[numberOfDigits];
            bool flag;
            int n;

            do
            {
                //generate a random number with the appropriate digits
                number = rand.Next((int) Math.Pow(10, numberOfDigits - 1), (int) Math.Pow(10, numberOfDigits));
                flag = true;
                n = number;

                for (int i = 0; i < numberOfDigits; i++)
                {
                    digits[i] = n % 10;
                    n = n / 10;

                    //Check for repeating digits
                    for (int j = 0; j != i && j <= i; j++)
                    {
                        if (digits[i] == digits[j])
                        {
                            flag = false;
                        }
                    }
                }
            } while (!flag);

            //The later is used for debugging purposes only and should not be enabled during a real game
            //Console.WriteLine(number);
        }

        //Method for playing the game
        static void PlayGame(int n, int numberOfDigits, int[] digitsFromRand)
        {
            bool guessed = false;
            int playerNumber;
            int tries = 1;

            Console.WriteLine(" -------------------------------");
            Console.WriteLine($"| Tries | Guess | Cows | Bulls |");
            Console.WriteLine(" -------------------------------");

            do
            {
                //Checks whether the number entered has the same length as the given random number
                do
                {
                    Console.Write("Enter your guess: ");
                } while (!int.TryParse(Console.ReadLine(), out playerNumber) ||
                         playerNumber.ToString().Length != numberOfDigits);

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);

                int[] a = new int[numberOfDigits];
                int b = playerNumber;
                int cow = 0;
                int bulls = 0;

                for (int i = 0; i < numberOfDigits; i++)
                {
                    a[i] = b % 10;
                    b = b / 10;

                    //Check for cows and bulls
                    for (int j = 0; j < numberOfDigits; j++)
                    {
                        if (a[i] == digitsFromRand[j])
                        {
                            cow++;
                            if (i == j)
                            {
                                cow--;
                                bulls++;
                            }
                        }
                    }
                }


                Console.WriteLine($"| {tries,-6}| {playerNumber,-6}| {cow,-5}| {bulls,-6}|");
                tries++;
                if (bulls == numberOfDigits) guessed = true;
            } while (!guessed);

            Console.WriteLine("Congratulations! You won!");
        }

        static void Main(string[] args)
        {
            
            while (true) // Continue the game until the user doesn't want to play anymore...
            {
                int numberOfDigits;
                
                do Console.Write("Number of digits: ");
                while (!int.TryParse(Console.ReadLine(), out numberOfDigits) || numberOfDigits <= 0 ||
                       numberOfDigits > 9);

                Program.GenerateNumber(numberOfDigits, out int number, out int[] digits);
                Program.PlayGame(number, numberOfDigits, digits);

                while (true) // Continue asking until a correct answer is given.
                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        return; // Exit the Main-method.
                }
            }
        }
    }
}