using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Story_Nickerson
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();
            Game();

        }
        static void Game()
        {
            string name = "";

            Console.WriteLine("Blurry shapes come into focus as your eyes open.");
            Console.WriteLine("Confused, you look around until you find a wallet on the ground beside you.");
            Console.WriteLine("Leaning down and picking it up, you notice a name engraved on the inside flap.\n");
            Console.WriteLine("What does the name say?");
            name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("A bit more reassured now that you know your name is " + name + ",");
            Console.WriteLine("the town in the distance looks a little more inviting.");
            Console.WriteLine("After a few minutes, you come across a shut gate with a knocker on the front.");
            Console.WriteLine("An older man opens a slot on the door asking for the password,");
            Console.WriteLine("which today, is a random number from one to three.\n");

            //random number generator. Guess correctly to move forward.
            Random rnd = new Random();
            int myrand = rnd.Next(2) + 1;
            bool exit;
            Greeting(myrand);
            do
            {
                int guess = int.Parse(Console.ReadLine());
                exit = Respond(guess, myrand);

            } while (!exit);

            Console.ReadLine();

            string town = "";

            Console.WriteLine("The elderly man who opened the door beckons you to enter the town");
            Console.WriteLine("before nightfall when apparently, bandits have been roaming.");
            Console.WriteLine("The town is a safe zone though, as the bandits have been unable");
            Console.WriteLine("to breach the walls and have been content taking their spoils");
            Console.WriteLine("from unsuspecting travelers caught outside at night.");
            Console.WriteLine("So it's a good thing you found your way to the town!\n");
            Console.WriteLine("Speaking of which, what does the sign with the town name above you say?\n");
            town = Console.ReadLine();
            Console.WriteLine("\n\n");

            Console.WriteLine("Before leaving, the watchman offers you one guess for extra defense");
            Console.WriteLine("for your journy through means of armor.");
            Console.WriteLine("All you have to do is guess the color. But you only get one chance!\n");

            //incorporate switch into a bonus
            string colorInput = "";

            Console.WriteLine("Guess the color (lowercase):");
            colorInput = Console.ReadLine();

            switch (colorInput)
            {
                case "green":
                    Console.WriteLine("\nCorrect! You now have extra protection.\n");
                    break;

                default:
                    Console.WriteLine("\nSorry, you guessed wrong.\n");
                    break;
            }
            string tavern = "";

            Console.WriteLine("Bidding the man farewell, you decide to search out a tavern");
            Console.WriteLine("to ask about who you might be.");
            Console.WriteLine("It makes sense someone in the town near where you woke up,");
            Console.WriteLine("would know you... right?\n\n");
            Console.WriteLine("You happen upon a tavern with an old, worn out sign.");
            Console.WriteLine("What does that say?\n");
            tavern = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Ah, yes. The " + tavern + ".\n");

            Console.WriteLine("Pushing the door open, the sounds of conversation and smells of fresh");
            Console.WriteLine("food and beer flood your senses. No one seems alarmed by your");
            Console.WriteLine("appearance though, as you would expect if someone knew you.");
            Console.WriteLine("Who knows how long you were unconscious out in the wild?\n\n");

            string meal = "";
            string barkeep = "";

            Console.WriteLine("Approaching the bar, you put in an order for food. What meal would you like?\n");
            meal = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("You purchase your " + meal + " with some of the remaining money from the wallet.");
            Console.WriteLine("While waiting for the food, you inquire about the bar keeps name.");
            Console.WriteLine("What name do they give you?\n");
            barkeep = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("When he returns with your " + meal + ", you ask if anyone has been searching");
            Console.WriteLine("for a missing person. Shaking their head, " + barkeep + " says no one in town");
            Console.WriteLine("or passing through has mentioned someone going missing. To them at least.\n");

            Console.WriteLine("Discouraged, you finish your " + meal + "before deciding to go wander");
            Console.WriteLine("the town of " + town + " more to see if anyone recognizes you.");
            Console.WriteLine("\"Where have you been!?\"\n");
            Console.WriteLine("It turns out, this person is your brother who had gotten separated from you");
            Console.WriteLine("while foraging in the woods the previous night.\n");
            Console.WriteLine("He said bandits had pursued you both and you split up to avoid them");
            Console.WriteLine("but he was unable to meet up with you again.\n\n");

            Console.WriteLine("Do you trust what this person says?\n");

            Console.WriteLine("Yes or No:\n");
            string Response = "";
            Response = Console.ReadLine();

            switch (Response)
            {
                case "Yes":
                    Console.WriteLine("Very well, you follow them to their home.\n");
                    Console.WriteLine("He shows you photos of the two of you together which jogs your memory.");
                    Console.WriteLine("Filled with relief, your journey has ended and you can relax.");
                    break;

                default:
                    Console.WriteLine("Very well, you leave and continue exploring the town.\n");
                    Console.WriteLine("Eventually the man returns with a photo as proof.");
                    Console.WriteLine("This jogs your memory and you leave with him, ending your journey.");
                    break;
            }

            Console.ReadLine();
            Console.Clear();           
        }

        static void DisplayHeader()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("===========Branches Cubed=============");
            Console.WriteLine("======================================");
            Console.ReadLine();
        }

        static void Greeting(int myrand)
        {
            Console.WriteLine("The number you guess is:");

        }
        static bool Respond(int guess, int myrand)
        {

            if (guess == myrand)
            {
                Console.WriteLine("Correct! The door before you opens.\n");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, keep guessing!\n");
                return false;
            }
        }

    }
}
