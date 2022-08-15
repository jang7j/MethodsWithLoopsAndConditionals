using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Method
    {

        public static void Thousands()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void ThreeToNineNineNine()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool isEqual(int a, int b)
        {
            var message = (a == b) ? true : false;
            return message;
        }
        public static void EvenOdd()
        {
            var evenOrOdd = int.Parse(Console.ReadLine());
            var result = (evenOrOdd % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);
        }
        public static void PositiveOrNegative()
        {
            var check = int.Parse(Console.ReadLine());
            if (check >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }
        public static void canVote()
        {
            Console.WriteLine("Enter your age : ");
            var age = int.Parse(Console.ReadLine());
            bool validNumber = int.TryParse(Console.ReadLine(), out int input);
            if (validNumber == true)
            {
                if (input >= 18)
                {
                    Console.WriteLine("You are eligible to vote");
                }
                else
                {
                    Console.WriteLine("Sorry you cannot vote");
                }
            }

            Console.WriteLine("Invalid input");



        }

    }
}

