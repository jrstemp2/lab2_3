using System;
using System.Text.RegularExpressions;

namespace Regexexample
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                //want a full name, first and last
                Console.Write("Please enter valid firstname: ");
                string name = Console.ReadLine();
                string namePattern = @"^[A-Z][A-Za-z'-]{0,29}$";

                if (Regex.IsMatch(name, namePattern))
                {
                    Console.WriteLine("This Name is Valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, this name is not valid!");
                }


                Console.WriteLine();
                Console.WriteLine("Please enter a valid email: ");
                string email = Console.ReadLine();
                string emailPattern = @"^[A-z\d\.-]{5,30}@[A-Za-z]{5,10}\.(([A-Za-z]{2,3})|([A-Za-z]{2}\.[A-Za-z]{2,3}))$"; 

                if (Regex.IsMatch(email, emailPattern))
                {

                    Console.WriteLine("This email is Valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, this email is not valid!");
                }

                Console.WriteLine();
                Console.WriteLine("Please enter a valid Phone Number: ");
                string phone = Console.ReadLine();
                string phonePattern = @"(1[0-9]{2}|[1-9]{3})-[0-9]{3}-[0-9]{4}";

                if (Regex.IsMatch(phone, phonePattern))
                {

                    Console.WriteLine("This phone number is Valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, this phone number is not valid!");
                }

                Console.WriteLine();
                Console.WriteLine("Please enter a valid date: ");
                string date = Console.ReadLine();
                string datePattern = @"(0[1-9]|1[0-9]|2[0-9]|3[01])\/(0[1-9]|1[0-2])\/[0-9]{4}";

                if (Regex.IsMatch(date, datePattern))
                {

                    Console.WriteLine("This date is Valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, this date is not valid!");
                }


            }




        }
    }
}
