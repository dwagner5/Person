using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProjectC
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _SSN;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

    }
    class Establishment : Person
    {
        private string _businessName;

        public string BusinessName
        {
            get { return _businessName; }
            set { _businessName = value; }
        }

    }

    class Employee : Establishment
    {
        private bool _isSalary;
        private string _department;
        private string _title;

        public bool IsSalary
        {
            get { return _isSalary; }
            set { _isSalary = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public void Pay(double payRate)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + "\nEstablishment: " + BusinessName);
            Console.WriteLine("Salary: " + IsSalary + "\nDepartment: " + Department);
            Console.WriteLine("Title: " + Title);
            if (IsSalary == true)
            {
                Console.WriteLine("Paid " + "$" + (payRate / 12.0).ToString("F2")); // salary divided into months
            }
            else
            {
                Console.WriteLine("Paid " + "$" + (payRate * 160.0).ToString("F2")); // 40 hr workweek x 4
            }
        }
    }

    class Management : Employee
    {
        public Management()
        {
            Title = "Management";
            IsSalary = true;
        }
    }
    class Staff : Employee
    {
        public Staff()
        {
            Title = "Staff";
            IsSalary = true;
        }

    }
    class Temp : Employee
    {
        public Temp()
        {
            Title = "Temp";
            IsSalary = false;
        }
    }
    class Customer : Establishment
    {
        public void Pay()
        {
            Console.WriteLine("I am a customer, and cannot be paid.");
        }

    }
    class Student : Establishment
    {
        public void Pay()
        {
            Console.WriteLine("I am a student, and cannot be paid.");
        }

    }
    class Administration : Employee
    {
        public Administration()
        {
            Title = "Administration";
            IsSalary = true;
        }

    }
    class Faculty : Employee
    {
        public Faculty()
        {
            Title = "Faculty";
            IsSalary = true;
        }

    }
    class FullTime : Faculty
    {
        public FullTime()
        {
            Title = "FullTime";
            IsSalary = true;
        }

    }
    class Adjunct : Faculty
    {
        public Adjunct()
        {
            Title = "Adjunct";
            IsSalary = false;
        }

    }
}
