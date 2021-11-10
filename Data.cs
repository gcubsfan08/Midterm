using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFarmos
{
    public static class Data
    {
        // stores all of the arrays for the game's dialogue
        // there are the things that the NPCs say, as well as what the player character says to get the NPCs to respond the way they do
 
        public static string[] MacDialogue = new string[] { "Welcome to MacPlace! Where we sell the best furniture in all of Los Farmos!", "What can I help you with today, shopper?",
                                                              "I will sell you this fantastic couch for a steal of a price!", "The all white couch would become a perfect addition to your collection!",
                                                              "Amber gave me a donation!? I really needed it, times are tough. Thank you to her and all of my sponsors!" };
        public static string[] MacTalk = new string[] { "Hello, Mac.", "Can I buy something in your store?", "I would like to buy your finest couch, please.", "You have a very nice all white couch in the corner, I would like that", "Amber wants you to have this, sir." };
        public static string[] AmberDialogue = new string[] { "Howdy, young person!", "Can you please give these thousand of dollars to Mac? He has hit hard times.", "I heard it was terrible, what a shame.",
                                                                "That is a shame to hear.", "I already have couches at home, no need. Bye!"};
        public static string[] AmberTalk = new string[] { "Hello Amber. Long time no see, eh?", "What do you want?", "Have you seen the newest Halloween movie? It was so bad.", "Yea, the original movie was so much better.", "I believe Mac is selling couches for a good price." };
        public static string[] JewelDialogue = new string[] { "Bark! Hello new friend!", "I want to go to the market, but my car is dead. Can you pick up my groceries?", "I have! It is so amazing, by far best album of the year.",
                                                             "It is, it sucks. I miss the summer. That flew by so fast.", "A brand new fridge?! I wanted this for a long time, thank you."};
        public static string[] JewelTalk = new string[] { "Nice to see you, Jewel.", "I can help with whatever you need.", "Have you listened to Kanye's newest album? It is so good.", "It is so cold at this time of year, wow.", "Here, I bought this at Mac's." };
        public static string[] RichDialogue = new string[] { "Hello, how are ya stranger?", "I have to get some bait to feed my cows. They have not had a good meal in a long time.\nI feel bad for them, I want them to eat something really nice!",
                                                              "I need to go there as well! Amazon messed up my order, so I have to return something. Messing up my morning.", "Yea, Macs is THE place to get a good deal. He does not rip off customers.",
                                                              "Thank you for some bait! Now my cows and other livestock can eat good for once!" };
        public static string[] RichTalk = new string[] { "Wonderful day Rich, isn't it?", "Is there anything that you need?", "I need to make a stop at the post office, I have to deliver this.", "I should have bought this at Macs, he has much better deal than big stores." };

        public static void ShowReputation()
        {
            if (Player.Reputation == 0)
            {
                Console.WriteLine("{0} has a neutral reputation, neither liked or disliked by people in Los Farmos", Player.Name);
            }
            else
            {
                if (Player.Reputation > 0)
                {
                    Console.WriteLine("{0} is loved and adored by the Los Farmos locals", Player.Name);
                }
                else
                {
                    Console.WriteLine("{0} is disliked by the people of Los Farmos", Player.Name);
                }
            }
        }

        // method for showing the position of the player on the map, as showing O and X.
        public static void ShowMap()
        {
            if ((Player.XPosition == 0) && (Player.YPosition == 0))
            {
                Console.WriteLine("X O O\nO O O\nO O O");
            }

            if ((Player.XPosition == 0) && (Player.YPosition == 1))
            {
                Console.WriteLine("O O O\nX O O\nO O O");
            }

            if ((Player.XPosition == 0) && (Player.YPosition == 2))
            {
                Console.WriteLine("O O O\nO O O\nX O O");
            }

            if ((Player.XPosition == 1) && (Player.YPosition == 0))
            {
                Console.WriteLine("O X O\nO O O\nO O O");
            }

            if ((Player.XPosition == 1) && (Player.YPosition == 1))
            {
                Console.WriteLine("O O O\nO X O\nO O O");
            }

            if ((Player.XPosition == 1) && (Player.YPosition == 2))
            {
                Console.WriteLine("O O O\nO O O\nO X O");
            }

            if ((Player.XPosition == 2) && (Player.YPosition == 0))
            {
                Console.WriteLine("O O X\nO O O\nO O O");
            }

            if ((Player.XPosition == 2) && (Player.YPosition == 1))
            {
                Console.WriteLine("O O O\nO O X\nO O O");
            }

            if ((Player.XPosition == 2) && (Player.YPosition == 2))
            {
                Console.WriteLine("O O O\nO O O\nO O X");
            }
        }
