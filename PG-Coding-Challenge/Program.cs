using System;

namespace PG_Coding_Challenge
{
    class Program
    {
         //****************************************************
        // Method: Main
        //
        // Create instance of Customer class, assigns data.
        // Displays menu to let the user choose which option they want to perform.
        //****************************************************
        static void Main(string[] args)
        {
            Customer c = new Customer();

            int userChoice = 0;
            while (userChoice != 4)
            {
                Console.WriteLine("Customer Menu");
                Console.WriteLine("------------");
                Console.WriteLine("1 - Enter Customer Information");
                Console.WriteLine("2 - Calculate estimate");
                Console.WriteLine("3 - Display customer information");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("Enter Choice:");
                String menuChoice = Console.ReadLine();
                userChoice = Convert.ToInt32(menuChoice);

                if (userChoice == 1)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    c.Name = name;

                    Console.Write("Enter age: ");
                    string age = Console.ReadLine();
                    int inputAge = Convert.ToInt32(age);
                    c.Age = inputAge;

                    Console.Write("Enter gender: ");
                    string gender = Console.ReadLine();
                    c.Gender = gender;

                    Console.Write("Enter condition (enter 'none' if none): ");
                    string condition = Console.ReadLine();
                    c.Condition = condition;
                }

                if (userChoice == 2)
                {
                    Console.WriteLine("Calculated Estimate: $" + c.CalculateEstimate().ToString("N2"));
                }

                if (userChoice == 3)
                {
                    Console.WriteLine(c.ToString());
                }
            }
        }
    }
}
