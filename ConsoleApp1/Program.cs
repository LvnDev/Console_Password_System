using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class ConsoleApp1
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Username"); //user creates account
            var user = Console.ReadLine();
            Console.WriteLine("Enter Password");
            var pass = Console.ReadLine();


            int i = 0;

            while (i < 3) //3 attemps until while loop ends
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Attempts: " + i);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Login");

            Console.WriteLine("Username: ");
            var input_user = Console.ReadLine();

            Console.WriteLine("Password: ");
            var input_pass = Console.ReadLine();

            if(input_user == user && input_pass == pass) //if equal pass and user
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Access Granted");
                Console.ForegroundColor = ConsoleColor.White;
                    break; //if pass and user break while loop
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Access Denied");
                Console.ForegroundColor = ConsoleColor.White;
                    i++; //add on attempt
             
            }
            }
            if(i == 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Locked..."); //remind user that they ran out of attempts
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
            Environment.Exit(0); //close console.
        }

    }
}