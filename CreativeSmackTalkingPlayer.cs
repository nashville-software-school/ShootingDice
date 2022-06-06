using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> InsultList {get;}
        
        public CreativeSmackTalkingPlayer()
        {
            InsultList = new List<string>() 
                {
                    "Go eat a cabbage!",
                    "You wreak of cheese and lies!", 
                    "Your face in insult enough!", 
                    "There's a snake in your boot!"
                };
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();
            Random r = new Random();
            int tauntNumber = r.Next(0,3);

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{InsultList[tauntNumber]}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }    
    }
}