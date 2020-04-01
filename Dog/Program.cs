using System;

namespace Homework_Dog
{
    class Dog
    {
        public Dog()
        {

        }
        public string Name;
        public string Race;
        public string Color;


        static void Main(string[] args)
        {
            #region Task7
            // Create a class Dog
            // Add properties: Name, race, color
            // The dog needs to have:
            // Eat method that returns message: The dog is now eating
            // Play method returning a message : The dog is now playing
            // ChaseTail method that returns a message: Dog is now chasing its tail.
            // The user needs to create the dog object by inputs and then given an option
            //  to choose one of the actions mentioned above.

            Dog Dog1 = new Dog();

            Dog1.Name = "";
            Dog1.Race = "";
            Dog1.Color = "";



            Console.Write("Please enter a Dog Name:");
            string Name = Console.ReadLine();
            Console.Write("Please enter a Dog Race:");
            string Race = Console.ReadLine();
            Console.Write("Please enter a Dog Color:");
            string Color = Console.ReadLine();

            Console.Write("Pleace enter a nuber: \n" +
                "No. (1) if The dog is now eating; \n" +
                "No. (2) The dog is now playing \n" +
                "No. (3) Dog is now chasing its tail.");
            int score = 0;
            bool validInput = int.TryParse(Console.ReadLine(), out score);

            if (score > 3 || score < 0 || validInput != true)
            {
                Console.WriteLine("You must enter a number from 1 to 3, PLEASE TRY AGAIN.");
            }

            else if (validInput == true)
            {
                switch (score)
                {
                    case 1:
                        Console.WriteLine($"The Dog {Name} Race {Race} Color {Color} is now eating");
                        break;
                    case 2:
                        Console.WriteLine($"The Dog {Name} Race {Race} Color {Color} is now playing");
                        break;
                    case 3:
                        Console.WriteLine($"The Dog {Name} Race {Race} Color {Color} is now chasing its tail");
                        break;
                        //Ovde treba da stavam default 

                }
                Console.ReadLine();
                #endregion
            }
        }
    }
}