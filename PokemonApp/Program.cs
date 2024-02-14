
/**
 * This program will display basic information based about a player who is playing Pokemon,
 * such as the trainer name, badges, and then will dislplay a 'win rate' of their battles 
 * using their battles they've won, and how many pokemon they've caught
 */


using static System.Console;

namespace PokemonApp
{
    internal class Program
    {
        // This method will be called in main to print a heading for the user
        static void PrintHeading()
        {
            WriteLine("***************************************************************");
            WriteLine("                     Pokemon Trainer Info App");
            WriteLine("***************************************************************");
            WriteLine();
        }
        static void Main(string[] args)
        {
            PrintHeading();

            // variable to determine whether or not our user will keep entering information
            bool keepGoing = true;

            // variables that will hold the trainers name, their badges, pokemon caught and battles won, as well as the win rate and an input string
            string trainerName;
            int numberOfBadges;
            int caughtPokemon;
            int trainerBattlesWon;
            double trainerWinRate;
            string input;


            do
            {
                try
                {
                    // Prompt user to enter the information such as their name, number of badges, number of pokemon caught, and how many battles they've won

                    WriteLine("Enter the information about your trainer:");

                    Write("Trainer's Name: ");
                    trainerName = Console.ReadLine();

                    Write("Number of Badges: ");
                    numberOfBadges = int.Parse(Console.ReadLine());

                    Write("Number of Pokemon Caught: ");
                    caughtPokemon = int.Parse(Console.ReadLine());

                    Write("Number of trainer battles won: ");
                    trainerBattlesWon = int.Parse(Console.ReadLine());
                    WriteLine();

                    // Now that we have the information, create a object from the PokemonPlayer class
                    PokemonPlayer player = new PokemonPlayer(trainerName, numberOfBadges, caughtPokemon, trainerBattlesWon);

                    // Display the information about the trainer to the user using the ToString
                    WriteLine("Here's your trainer's information: ");
                    WriteLine(player.ToString());

                    // Calculate the player's win rate in battle and display it to them
                    trainerWinRate = player.trainerWinRate();
                    WriteLine($"Trainer Win Rate: {trainerWinRate:P}");

                    // Ask the user if they would like to enter more information, and if so keep the program running or else quit the program
                    Write("\nDo you want to enter more trainers? (y/n): ");
                    input = ReadLine();
                    if (input.ToLower() == "n")
                    {
                        keepGoing = false;
                    } else
                    {
                        keepGoing = true;
                    }

                } catch (Exception e)
                {
                    WriteLine("\nYou made an error in your input ");
                    WriteLine($"Here is the error message: {e.Message} \nResetting the program.");
                    keepGoing= true;
                }
            } while (keepGoing);
            WriteLine("\nThank you for using the Pokemon Trainer App");
        }
    }
}
