using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2_DSA
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

        public void Sort(string sortDirection, int sortField)
        {
            if (sortField == 1) //i used this sort because we don't have many students in the data structure, but if we had more students we should use a more optimized one
            {
                if (sortDirection == "asc") // by first name ascendant 
                {
                    int inerator = 0;
                    int n = dataBase.Count - 1;
                    int letter = 0;
                    while (inerator < dataBase.Count)
                    {
                        for (int i = n; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                while (dataBase.ElementAt(j - 1).GetFirstName[letter] == dataBase.ElementAt(j).GetFirstName[letter])
                                {
                                    letter++;
                                }
                                if (dataBase.ElementAt(j - 1).GetFirstName[letter] > dataBase.ElementAt(j).GetFirstName[letter])
                                {
                                    Student temp = dataBase.ElementAt(j - 1);
                                    dataBase.Remove(dataBase.ElementAt(j - 1));
                                    dataBase.AddLast(temp);
                                    inerator = 0;                                    
                                }
                                inerator++;
                                letter = 0;
                            }
                        }
                    }
                }


                if (sortDirection == "desc") // by first name descendant 
                {
                    int inerator = 0;
                    int n = dataBase.Count - 1;
                    int letter = 0;
                    while (inerator < dataBase.Count)
                    {
                        for (int i = n; i >= 0; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                while (dataBase.ElementAt(j - 1).GetFirstName[letter] == dataBase.ElementAt(j).GetFirstName[letter])
                                {
                                    letter++;
                                }
                                if (dataBase.ElementAt(j - 1).GetFirstName[letter] < dataBase.ElementAt(j).GetFirstName[letter])
                                {
                                    Student temp = dataBase.ElementAt(j - 1);
                                    dataBase.Remove(dataBase.ElementAt(j - 1));
                                    dataBase.AddLast(temp);
                                    inerator = 0;
                                }
                                inerator++;
                                letter = 0;
                            }
                        }
                    }
                }
            }


            if (sortField == 2) // LAST NAME
            {
                if (sortDirection == "asc") // by last name ascendant 
                {
                    int inerator = 0;
                    int n = dataBase.Count - 1;
                    int letter = 0;
                    while (inerator < dataBase.Count)
                    {
                        for (int i = n; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                while (dataBase.ElementAt(j - 1).GetLastName[letter] == dataBase.ElementAt(j).GetLastName[letter])
                                {
                                    letter++;
                                }
                                if (dataBase.ElementAt(j - 1).GetLastName[letter] > dataBase.ElementAt(j).GetLastName[letter])
                                {
                                    Student temp = dataBase.ElementAt(j - 1);
                                    dataBase.Remove(dataBase.ElementAt(j - 1));
                                    dataBase.AddLast(temp);
                                    inerator = 0;
                                }
                                inerator++;
                                letter = 0;
                            }
                        }
                    }
                }


                if (sortDirection == "desc") // by last name descendant 
                {
                    int inerator = 0;
                    int n = dataBase.Count - 1;
                    int letter = 0;
                    while (inerator < dataBase.Count)
                    {
                        for (int i = n; i >= 0; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                while (dataBase.ElementAt(j - 1).GetLastName[letter] == dataBase.ElementAt(j).GetLastName[letter])
                                {
                                    letter++;
                                }
                                if (dataBase.ElementAt(j - 1).GetLastName[letter] < dataBase.ElementAt(j).GetLastName[letter])
                                {
                                    Student temp = dataBase.ElementAt(j - 1);
                                    dataBase.Remove(dataBase.ElementAt(j - 1));
                                    dataBase.AddLast(temp);
                                    inerator = 0;
                                }
                                inerator++;
                                letter = 0;
                            }
                        }
                    }
                }
            }


            if (sortField == 3) // AVERAGE SCORE
            {
                if (sortDirection == "asc") // by AVERAGE ascendant 
                {
                    int inerator = 0;
                    int n = dataBase.Count - 1;
                    while (inerator < dataBase.Count)
                    {
                        for (int i = n; i >= 1; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (dataBase.ElementAt(j - 1).GetAverageScore > dataBase.ElementAt(j).GetAverageScore)
                                {
                                    Student temp = dataBase.ElementAt(j - 1);
                                    dataBase.Remove(dataBase.ElementAt(j - 1));
                                    dataBase.AddLast(temp);
                                    inerator = 0;
                                }
                                inerator++;
                            }
                        }
                    }
                }


                if (sortDirection == "desc") // by last name descendant 
                {
                    int inerator = 0;
                    int n = dataBase.Count - 1;
                    while (inerator < dataBase.Count)
                    {
                        for (int i = n; i >= 0; i--)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (dataBase.ElementAt(j - 1).GetAverageScore < dataBase.ElementAt(j).GetAverageScore)
                                {
                                    Student temp = dataBase.ElementAt(j - 1);
                                    dataBase.Remove(dataBase.ElementAt(j - 1));
                                    dataBase.AddLast(temp);
                                    inerator = 0;
                                }
                                inerator++;
                            }
                        }
                    }
                }
            }
        }

        public void GetMaxElement()
        {
            if (dataBase.Count != 0)
            {
                Student studentMax = dataBase.ElementAt(0);
                foreach (var student in dataBase)
                {
                    if (student.GetAverageScore > studentMax.GetAverageScore)
                    {
                        studentMax = student;
                    }
                }
                Console.WriteLine(studentMax.GetFullName + " has the highest average score, with an average of " + studentMax.GetAverageScore + ".");
            }
            else
            {
                Console.WriteLine("There is no student in the list ");
            }
        }

        public void GetMinElement()
        {
            if (dataBase.Count != 0)
            {
                Student studentMin = dataBase.ElementAt(0);
                foreach (var student in dataBase)
                {
                    if (student.GetAverageScore < studentMin.GetAverageScore)
                    {
                        studentMin = student;
                    }
                }
                Console.WriteLine(studentMin.GetFullName + " has the lowest average score, with an average of " + studentMin.GetAverageScore + ".");
            }
            else
            {
                Console.WriteLine("There is no student in the list ");
            }
        }
    }
}
