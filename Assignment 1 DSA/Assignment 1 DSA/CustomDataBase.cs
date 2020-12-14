using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_1_DSA
{
    class CustomDataBase
    {
        private LinkedList<Student> dataBase;


        public CustomDataBase()
        {
            this.dataBase = new LinkedList<Student>();
        }

        public LinkedList<Student> GetDataBase
        {
            get { return dataBase; }
        }

        public void PopulateWithSampleStudent()
        {
            float[] score1 = { 25, 50, 75, 80 };
            Student student1 = new Student("Nico", "Vanderstigel", "702717", score1);
            float[] score2 = { 20, 40, 65, 90 };
            Student student2 = new Student("Quentin", "Muller", "563HF7", score2);
            float[] score3 = { 40, 60, 45, 95 };
            Student student3 = new Student("Tom", "Mouly", "23KHV57", score3);
            float[] score4 = { 15, 30, 45, 60 };
            Student student4 = new Student("Hippo", "Guesdon", "GH34V78", score4);
            dataBase.AddFirst(student1);
            dataBase.AddFirst(student2);
            dataBase.AddFirst(student3);
            dataBase.AddFirst(student4);
        }

        public void Add(Student student)
        {
            dataBase.AddLast(student);
        }

        public void GetElementByIndex(int index)
        {
            Console.WriteLine(dataBase.ElementAt(index).ToString());
        }

        public void RemoveByIndex(int index)
        {
            dataBase.Remove(dataBase.ElementAt(index));
        }

        public void RemoveFirst()
        {
            dataBase.RemoveFirst();
        }
        public void RemoveLast()
        {
            dataBase.RemoveLast();
        }

        public void DisplayList()
        {
            if (dataBase.Count != 0)
            {
                Console.WriteLine("These are the differents informations about your student :");
                Console.WriteLine();
                foreach (var student in dataBase)
                {
                    Console.WriteLine(student.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no student in the list ");
            }
        }

    }
}
