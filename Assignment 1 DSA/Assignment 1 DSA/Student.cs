using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_DSA
{
    class Student
    {
        private string studentNumber;
        private float[] scores;
        private float averageScore;
        private string fullName;
        private string firstName;
        private string LastName;

        public Student(string firstName, string lastName, string studentNumber, float[] scores)
        {
            this.studentNumber = studentNumber;
            this.scores = scores;
            this.firstName = firstName;
            this.LastName = lastName;
            this.averageScore = Average(scores);
            this.fullName = firstName + " " + lastName;
        }

        public string StudentNumber
        {
            get { return studentNumber; }
        }
        public float[] Scores
        {
            get { return scores; }
        }
        public double GetAverageScore
        {
            get { return averageScore; }
        }
        public string GetFullName
        {
            get { return fullName; }
        }
        public string GetFirstName
        {
            get { return firstName; }
        }

        public string GetLastName
        {
            get { return LastName; }
        }

        public string GetStudentNumber
        {
            get { return StudentNumber; }
        }

        public float[] GetScores
        {
            get { return scores; }
        }

        public float Average(float[] scores)
        {
            float average = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                average = average + scores[i];
            }
            average = average / scores.Length;
            return average;
        }


        public override string ToString()
        {
            string answer = fullName + " 's student number is " + studentNumber + ".\nAll his grades are : ";
            for (int i = 0; i < scores.Length; i++)
            {
                answer = answer + scores[i] + " ";
            }
            answer = answer + ".\nHis average score is " + averageScore;
            answer = answer + ".\n ";
            return answer;
        }
        }
    }

