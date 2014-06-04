/*Problem 12.	Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a 
single bank account using the appropriate data types and descriptive names.*/

using System;
    class BankAccData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Nikolov";
            string lastName = "Georgiev";
            decimal balance = 3000.00m;
            string bankName = "PIB";
            string IBAN = "BG32 UBBS 7827 1013 6179 06";
            ushort secCode = 324;

            Console.WriteLine(
                              "Your bank account data: \n" +
                              "First name: " + firstName  + "\n" +
                              "Middle name: " + middleName + "\n" +
                              "Last name: " + lastName + "\n" +                                    
                              "Balance: " + balance + " lv\n" +
                              "Bank name: " + bankName + "\n" +
                              "IBAN: " + IBAN + "\n" +
                              "Security code: " + secCode + "\n"
                             );
        }
    }