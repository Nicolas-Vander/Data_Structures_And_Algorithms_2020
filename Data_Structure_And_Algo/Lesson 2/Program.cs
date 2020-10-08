using System;
using System.Collections.Generic;

namespace Lesson_2
{
    class Program
    {
        static string GetMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "February";
            if (month == 3) return "March";
            if (month == 4) return "April";
            if (month == 5) return "May";
            if (month == 6) return "June";
            if (month == 7) return "July";
            if (month == 8) return "August";
            if (month == 9) return "September";
            if (month == 10) return "October";
            if (month == 11) return "November";
            if (month == 12) return "December";
            return "Impossible";
        }

        static void Task1()
        {
            {
                string[] names = { "Nicolas", "Hippo", "Tom", "Aymeric" };

                DateTime[] bdays = new DateTime[names.Length];
                bdays[0] = new DateTime(2000, 04, 06);
                bdays[1] = new DateTime(2001, 09, 23);
                bdays[2] = new DateTime(2002, 05, 10);
                bdays[3] = new DateTime(2006, 08, 03);

                Console.WriteLine("Which index do you want between 0 and 3");
                int index = int.Parse(Console.ReadLine());

                int dayOfBirth = bdays[index].Day;
                string periodOfTheMonth = "Beginning";

                if (dayOfBirth > 10)
                {
                    periodOfTheMonth = "middle";
                }

                if (dayOfBirth > 20)
                {
                    periodOfTheMonth = "end";
                }
                string nameOfTheMonth = GetMonth(bdays[index].Month);

                Console.WriteLine($"{names[index]}'s born in the {periodOfTheMonth} in {nameOfTheMonth}");
            }
        }


        static void Task2()
        {
            string sentance = "My program is used to display the longest word of this sentance";

            string[] words = sentance.Split(" ");

            string longest = "";
            foreach (string word in words)
            {
                if (longest.Length < word.Length)
                {
                    longest = word;
                }
            }

            Console.WriteLine("The longest word is " + longest);
        }

        static void Task3()
        {
            string sentance = "Display the pattern like pyramid using the alphabet";

            string[] words = sentance.Split(" ");
            Stack<string> stack = new Stack<string>();

            foreach (string word in words)
            {
                stack.Push(word);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine("");
        }

        static void HomeWork1()
        {
            int[] myArray = { 1, 3, 4, 7, 9, 11, 15, 18, 20, 25 };
            Console.Write("You array is ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Which number do you want to check ?");
            int number = Convert.ToInt32(Console.ReadLine());
            string reponse = "Your number is not in the list ";
            for (int i = 0; i < myArray.Length; i++)
            {
               if (number == myArray[i])
                {
                    reponse = "Your number is in the list ";
                }
            }
            Console.WriteLine(reponse);
        }

        static void HomeWork2()
        {
            Stack<int> numbers = new Stack<int>();
            for (int i = 1; i < 20; i = i+2)
            {
                numbers.Push(i);
            }
            foreach (int number in numbers)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine("");
            Stack<int> stackCopy = new Stack<int>(numbers.ToArray());
            Console.WriteLine("Which number do you want to check ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            string reponse = "Your number is not in the list ";
            for (int i = 0; i < stackCopy.Count; i++)
            {
                if (answer == numbers.Pop())
                {
                    reponse = "Your number is in the list ";
                }
            }
            Console.WriteLine(reponse);
        }

        static void HomeWork3()
        {
            Queue<int> numbers = new Queue<int>();
            for (int i = 1; i < 20; i = i + 2)
            {
                numbers.Enqueue(i);
            }
            foreach (int number in numbers)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine("");
            Queue<int> queueCopy = new Queue<int>(numbers.ToArray());
            Console.WriteLine("Which number do you want to check ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            string reponse = "Your number is not in the list ";
            for (int i = 0; i < queueCopy.Count; i++)
            {
                if (answer == numbers.Dequeue())
                {
                    reponse = "Your number is in the list ";
                }
            }
            Console.WriteLine(reponse);
        }

        static void HomeWork4()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < 20; i = i + 2)
            {
                numbers.Add(i);
            }
            foreach (int number in numbers)
            {
                Console.Write(" " + number);
            }
            Console.WriteLine("");
            Console.WriteLine("Which number do you want to check ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            string reponse = "Your number is not in the list ";
            if (numbers.Contains(answer))
            {
                reponse = "Your number is in the list ";
            }
            
            Console.WriteLine(reponse);
        }

        static void Main(string[] args)
        {
            HomeWork4();
        }
    }
}
