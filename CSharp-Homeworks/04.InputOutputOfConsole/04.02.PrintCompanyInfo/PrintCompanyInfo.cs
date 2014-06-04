/*Problem 2.	Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
age and a phone number. Write a program that reads the information about a company and its manager and prints it 
back on the console.*/

using System;

    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.Write("Company: ");
            string company = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNum = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager's first name: ");
            string ManagerFirstName = Console.ReadLine();
            Console.Write("Manager's last name: ");
            string ManagerLastName = Console.ReadLine();
            Console.Write("Manager's age: ");
            string ManagerAge = Console.ReadLine();
            Console.Write("Manager's phone number: ");
            string ManagerphoneNum = Console.ReadLine();

            Console.WriteLine("\nYou entered: \n" + company + "\n" + address + "\n" + phoneNum + "\n" + faxNum + "\n" + 
                                webSite + "\n" + ManagerFirstName + "\n" + ManagerLastName + "\n" + ManagerAge + "\n" + 
                                ManagerphoneNum);
        }
    }