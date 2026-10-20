using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Student
    {

        private int id;
        private string name;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private bool hasScholarship;
        private char  classLetter;
        private DateTime birthDate;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id
        {
            get { return id; }

            private set
            {
                if  (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(id), "Id must be a positive integer.");
                }
                id = value;
            }

        }
       
        public string Name

        {


            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!.");
                   
                }

                name = value;
            }


        }

        
        public int Age
        { 
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException(nameof(age),"Age must be between 6 and 20.");
                }
                age = value;
            }
        }

     
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value> 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Grade must be between 1 and 12.");
                }
                grade = value;
            }
        }


       
        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException(nameof(averageScore), "Average score must be between 2.00 and 6.00.");
                }
                averageScore = value;
            }
        }




        
        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(fee), "Fee cannot be negative.");
                }
                fee = value;
            }
        }


        public bool HasScholarship
        {
            get { return hasScholarship; }
            set { hasScholarship = value; }
        }

        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))
                {
                    throw new ArgumentException("Class letter must be a letter.");
                }
                classLetter = value;
            }
        }
        
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Birth date cannot be in the future.");
                }
                birthDate = value;
            }







}






}
}
