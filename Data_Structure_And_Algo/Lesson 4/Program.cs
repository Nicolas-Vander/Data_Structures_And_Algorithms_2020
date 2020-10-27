using System;
using System.Collections.Generic;

namespace Lesson_4
{
    class Program
    {
        static void StudentMarks()
        {
            Dictionary<string, int> studentMarks = new Dictionary<string, int>();

            studentMarks.Add("Hippo", 90);
            studentMarks.Add("Tom", 60);
            studentMarks.Add("Nico", 70);
            foreach (var studentMark in studentMarks)
            {
                Console.WriteLine($"Student {studentMark.Key}, mark : {studentMark.Value}");
            }

            while (true)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("What name do you want to search ? ");
                string name = Console.ReadLine();

                if (studentMarks.ContainsKey(name))
                {
                    Console.WriteLine($"Student :'{name}' has a score of {studentMarks[name]}.");
                }

                else
                {
                    Console.WriteLine($"The student '{name}' does not exist.");
                }
            }
        }


        static void HomeWork1()
        {
            Console.WriteLine("What size of square do you want (no more than 25x25");
            int size = Convert.ToInt32(Console.ReadLine());
            bool[,] battlefield = new bool[size, size];
            char[,] displayBattlefield = new char[size, size];
            bool loose = false;
            int x = 0;
            int y = 0;
            Random random = new Random();    
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int randomNumber = random.Next(0, 2);
                    if (randomNumber == 0)
                    {
                        battlefield[i, j] = false;
                        displayBattlefield[i, j] = 'O';
                    }
                    else
                    {
                        battlefield[i, j] = true;
                        displayBattlefield[i, j] = 'X';
                    }
                }
            }
            while (loose == false)
            {                    
                for (int i = 0; i < displayBattlefield.GetLength(0); i++)
                {
                    for (int j = 0; j < displayBattlefield.GetLength(1); j++)
                    {
                        Console.Write(displayBattlefield[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("What coords do you want to test ? X first");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What coords do you want to test ? X first");
                y = Convert.ToInt32(Console.ReadLine());
                if (battlefield[x,y] == true)
                {
                    loose = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("YEAH ! No mine");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("BOOM ! There was a mine");
        }

        static void Insert(Dictionary<string,int> contacts)
        {
            Console.WriteLine("What is the phone number of your new contact ?");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the name of your new contact ?");
            string name = Convert.ToString(Console.ReadLine());
            contacts.Add(name,phoneNumber);
            Console.WriteLine();
        }

        static void Delete(Dictionary<string,int> contacts)
        {
            Console.WriteLine("What is the name of the contact you want to delete ?");
            string name = Convert.ToString(Console.ReadLine());
            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
                Console.WriteLine("This contact has been delete with success");
            }
            else
            {
                Console.WriteLine("This name is not in your contact list ");
            }
            Console.WriteLine();
        }

        static void Search(Dictionary<string,int> contacts)
        {
            Console.WriteLine("What is the name of the contact you want to search ?");
            string name = Convert.ToString(Console.ReadLine());
            if (contacts.ContainsKey(name))
            {
                contacts.TryGetValue(name,out int number);
                Console.WriteLine("The number of " + name + " is : " + number);
            }
            else
            {
                Console.WriteLine("The name " + name + " is not in your contact list");
            }
            Console.WriteLine();
        }

        static void List(Dictionary<string,int> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} number : {contact.Value}");
            }
            Console.WriteLine();
        }
        static void HomeWork2()
        {
            Dictionary<string, int> contacts = new Dictionary<string, int>();
            int answer = 5;
            bool escape = false;
            while (escape == false)
            {
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine();
                Console.WriteLine("Tape 1 to INSERT a contact");
                Console.WriteLine("Tape 2 to DELETE a contact");
                Console.WriteLine("Tape 3 to SEARCH a contact");
                Console.WriteLine("Tape 4 to LIST all contacts");
                Console.WriteLine("Tape 0 to STOP the program");
                Console.WriteLine();
                answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1: Insert(contacts); break;
                    case 2: Delete(contacts); break;
                    case 3: Search(contacts); break;
                    case 4: List(contacts); break;
                    case 0: escape = true; break;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            HomeWork2();
        }
    }
}
