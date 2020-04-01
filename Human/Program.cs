using System;

namespace Human
{
    //Create a class Human
    //Add properties: FirstName, LastName, Age
    //Create a method called GetPersonStats that returns the full name of the human as well as their age
    //Create an object human by asking the user to fill the required information
    //Call the GetPersonStats method and print the result in the console after the object is created

    class Human
    {
        public Human()
        {

        }
        public string FirstName;
        public string LastName;
        public string Age;
        static void Main(string[] args)
        {
            Human Human1 = new Human();

            Human1.FirstName = "";
            Human1.LastName = "";
            Human1.Age = "";



            Console.Write("Please enter a First Name:");
            string FirstName = Console.ReadLine();
            Console.Write("Please enter a Last Name:");
            string LastName = Console.ReadLine();
            Console.Write("Please enter your Age:");
            string Age = Console.ReadLine();

            Console.WriteLine($"Your Name is {FirstName} {LastName} and you heve {Age}  ");
        }
    }
}
