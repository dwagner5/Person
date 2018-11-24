using System;

class Person
{
	private string _firstName;
	private string _lastName;
	private string _SSN;
	private string _gender;
	
	public Person(firstName, lastName, SSN, gender)
	{
		_firstName = firstName;
		_lastName = lastName;
		_SSN = SSN;
		_gender = gender;
	}
	
	public void pay()
	{
		println(_firstName + _lastName + " got paid.");
	}
	

}
// Business Classes
class Business : Person
{
	private string _businessName = "Dakota Central Telecommunications";

}
class Employee : Business
{
	private int _employeeID;
	private bool _isSalary;
	private string _department;
	private string _title;

}
class Management : Employee
{
	private int _salary = 40000;

}
class Staff : Employee
{
	private int _salary = 40000;

}
class Temp : Employee
{
	private int _hourlyRate = 20;

}
class Customer : Business
{
	private int _customerID;

}
// School Classes
class School : Person
{
	private string _schoolName = "University of Jamestown";
}
class Student : School
{
	private int _studentID;

}
class SchoolEmployee : School
{
	private int _employeeID;
	private string _department;
	private bool _isSalary;
	private string _title;
	

}
class Administration : SchoolEmployee
{
	private int _salary = 40000;

}
class Faculty : SchoolEmployee
{
	private bool _isFullTime;

}
class FullTime : Faculty
{
	private int _salary = 40000;

}
class Adjunct : Faculty
{
	private int _hourlyWage = 20;

}
class Staff : SchoolEmployee
{
	private int _salary = 40000;

}






