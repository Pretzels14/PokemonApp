using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    internal class PokemonPlayer
    {
        // declare our variables of the user, such as the name, badgees, and their pokemon caught and battles won
        public string TrainerName { get; set; }
        public int TrainerBadges { get; set; }
        private int caughtPokemon;
        private int battlesWon;

        // Use property to acccess the caughtPokemon variable
        public int CaughtPokemon
        {
            get { return caughtPokemon; } // return the caughtPokemon
            
            // Set the caughtPokemon to be equal to the value entered, or 0 if there are no caught pokemon
            set
            {
                if (value >= 0)
                {
                    caughtPokemon = value;
                }
                else
                    caughtPokemon = 0;
            }
        }

        // Use property to acccess thee battlesWon variable

        public int BattlesWon
        {
            get { return battlesWon; } // returns the number of battles won
           
            // Set's the battles won to be equal to the value inputted, and defaults to zero if there is no value
            set
            {
                if (value >= 0) 
                    battlesWon = value;
                else 
                    battlesWon = 0;
            }
        }

        // Set default constructor for our values, using an empty string as the default name and 0 for the ints
        public PokemonPlayer()
        {
            TrainerName = "Unknown";
            TrainerBadges = 0;
            caughtPokemon = 0;
            battlesWon = 0;
        }
        // Set our actual constructor, which will take in a name and number of badges, pokemon caught, and battles won
        public PokemonPlayer(string trainerName, int trainerBadges, int caughtPokemon, int battlesWon)
        {
            TrainerName = trainerName;
            TrainerBadges = trainerBadges;
            this.caughtPokemon = caughtPokemon;
            this.battlesWon = battlesWon;
        }

        // This method will be used to calculate the player's win rate in battle, using their battles won and pokemon caught
        public double trainerWinRate()
        {
            // if no battles have been won, the win rate will be zero, elsee return the value of their battles won divided by the total of their won battles and caught pokemon
            if (battlesWon == 0)
            {
                return 0;
            }
            else
            {
                return (double)battlesWon / (battlesWon + caughtPokemon);
            }
        }

        // ToString method that allows our user to see properly displayed information of what they entered and the calculated information
        public override string ToString()
        {
            return $"Trainer Name: {TrainerName}\nTrainerBadges: {TrainerBadges}\nNumber of Pokemon Caught: {CaughtPokemon}\nNumber of Trainer Battles Won: {BattlesWon}";
        }
    }
}

