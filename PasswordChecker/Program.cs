using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty123";
            int attemps = 5;

            for (int i = 1; i <= attemps; i++)
            {
                Console.Write("Enter the password: ");
                string tempPassword = Console.ReadLine();
                if (tempPassword == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    Console.WriteLine("Access Granted!");
                    break;
                } 
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Access denied");
                    Console.WriteLine("");
                    if (i == attemps) Console.WriteLine("Your account has been blocked");
                    Console.ResetColor();
                }
            }
            Console.Read();
        }
    }
}
