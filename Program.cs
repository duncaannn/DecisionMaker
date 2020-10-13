using System;
using System.IO;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Console.WriteLine("Hello User! What's your name?");
            userName = Console.ReadLine();

            while (true)
            {
                while (true)
                {
                    if (string.IsNullOrEmpty(userName))
                    {
                        Console.WriteLine("Name cannot be empty. Please input your name.");
                        userName = Console.ReadLine();
                    }
                    else
                    {
                        break;
                   }
                }
                Console.WriteLine(userName + ", please enter an integer between 1 and 100.");
                int userInput;
               userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput > 100)
                { Console.WriteLine("Number must be between 1 and 100."); }
                {


                    if (userInput % 2 == 0 && userInput > 2 && userInput < 25)
                    {
                        Console.WriteLine("Number is even and less than 25," + userName);
                    }
                    else if (userInput % 2 != 0 && userInput < 101)
                    {
                        Console.WriteLine("Number is odd, " + userName);
                    }
                    else if (userInput % 2 == 0 && userInput > 26 && userInput < 60)
                    {
                        Console.WriteLine("Number is even, " + userName);
                    }
                    else if (userInput % 2 == 0 && userInput > 60 && userInput < 101)
                    {
                        Console.WriteLine("Number is even, " + userName);
                    }
                    else if (userInput % 2 != 0 && userInput > 60 && userInput < 101)
                    {
                        Console.WriteLine("Number is odd, " + userName);
                    }
                    {
                        Console.WriteLine("Would you like to continue, " + userName + "? yes/no");
                        string userResponse = Console.ReadLine();
                        if (userResponse != "yes")
                        {

                            if (userResponse == "no")
                            {
                                Console.WriteLine("Have a nice day, " + userName);
                               break;                              
                            }
                        }
                    }

                }

            }
        }
    }
}




