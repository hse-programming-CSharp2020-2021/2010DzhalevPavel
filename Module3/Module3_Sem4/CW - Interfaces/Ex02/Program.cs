using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace Ex02
{
    class Program
    {
        /*
         * Написать программу, которая определяет, является ли введенная скобочная
         * структура правильной. Примеры правильных скобочных выражений:
         * (), (())(), ()(), ((())), неправильных — )(, ())((), (, )))),
         * ((()). Учесть виды скобок ( { [
         */
        static void Main(string[] args)
        {
            var dict = new Dictionary<char, char>{
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };

            var input = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();

            try
            {
                foreach (var letter in input.ToString())
                {
                    if (dict.Keys.Contains(letter))
                    {
                        brackets.Push(letter);
                    }

                    if (dict.Values.Contains(letter))
                    {
                        if (brackets.Count > 0)
                        {
                            if (dict[brackets.Pop()] != letter)
                                throw new Exception("This is not a correct string!");
                        }else throw new Exception("This is not a correct string!");
                        
                    }
                }
                
                Console.WriteLine("This is a correct string :)");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}