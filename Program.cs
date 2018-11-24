using System;

namespace ObjectOrientedProjectC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Dakota Wagner's Class Inheritance Project.\n");

            // Management example - utilizes the Salary aspect of the Pay() method
            Management Dakota = new Management();
            Dakota.FirstName = "Dakota";
            Dakota.LastName = "Wagner";
            Dakota.BusinessName = "JPS";
            Dakota.Department = "Computer Science";
            Dakota.Pay(45000); // 45,000 yearly divided by 12

            Console.WriteLine();

            // Staff example - utilizes the Salary aspect of the Pay() method
            Staff Bob = new Staff();
            Bob.FirstName = "Bob";
            Bob.LastName = "McGee";
            Bob.BusinessName = "JPS";
            Bob.Department = "Maintenance";
            Bob.Pay(30000); // 30,000 yearly divided by 12

            Console.WriteLine();

            // Temp example - utilizes the non Salary aspect of the Pay() method
            Temp Jack = new Temp();
            Jack.FirstName = "Jack";
            Jack.LastName = "Johnson";
            Jack.BusinessName = "JPS";
            Jack.Department = "Camel Artisan";
            Jack.Pay(15.00); // 15.00 an hour

            Console.WriteLine();

            // Administration example - utilizes the Salary aspect of the Pay() method
            Administration Billy = new Administration();
            Billy.FirstName = "Billy";
            Billy.LastName = "Bob";
            Billy.BusinessName = "UJ";
            Billy.Department = "IT";
            Billy.Pay(50000); // 50,000 yearly divided by 12

            Console.WriteLine();

            // Staff example - utilizes the Salary aspect of the Pay() method
            Staff Jackie = new Staff();
            Jackie.FirstName = "Jackie";
            Jackie.LastName = "McGee";
            Jackie.BusinessName = "UJ";
            Jackie.Department = "IT";
            Jackie.Pay(40000); // 40,000 yearly divided by 12

            Console.WriteLine();

            // FullTime Faculty example - utilizes the Salary aspect of the Pay() method
            FullTime Jim = new FullTime();
            Jim.FirstName = "Jim";
            Jim.LastName = "Woom";
            Jim.BusinessName = "UJ";
            Jim.Department = "Physical Education";
            Jim.Pay(30000); // 30,000 yearly divided by 12

            Console.WriteLine();

            // PartTime Faculty example - utilizes the Salary aspect of the Pay() method
            Adjunct Sharon = new Adjunct();
            Sharon.FirstName = "Sharon";
            Sharon.LastName = "McAppleJacks";
            Sharon.BusinessName = "UJ";
            Sharon.Department = "Arts";
            Sharon.Pay(20.00); // 20.00 hourly 

            Console.WriteLine();




            Console.ReadKey();
        }
    }
}
