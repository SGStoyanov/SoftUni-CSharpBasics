/*Problem 11.	Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
 * Use descriptive names. Print the data at the console.*/

using System;
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Petar";
            string lastName = "Petrov";
            sbyte age = 32;
            char gender = 'm';
            long personalIDnum = 8302379528;
            double employeeNumber = 3838439812312833824d;

            Console.WriteLine("First name: " + firstName + '\n' +
                              "Last name: " + lastName + '\n' +
                              "Age: " + age + '\n' +
                              "Gender: " + gender + '\n' +
                              "Personal ID number: " + personalIDnum + '\n' +
                              "Employee number: " + employeeNumber);        }
    }