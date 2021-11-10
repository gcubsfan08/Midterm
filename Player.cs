using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFarmos
{
    public static class Player
    {
        public static string Name = "";
        public static List<string> Inventory = new List<string>();
        public static int XPosition = 0;
        public static int YPosition = 0;
        public static int Days = 0;

        // some of the variables that will be referenced in the ending of the game
        public static bool DeliveredMoney = false;
        public static bool DeliveredGroceries = false;
        public static bool DeliveredBait = false;
        public static int Reputation = 0;

        // allows for the player to name their character
        public static void NamePlayer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Every time you see the ~ symbol, you need to press enter to continue. ~ \nIf you do not see that symbol, well then just press enter anyways unless prompted otherwise.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What would you like to name your farmer?");
            Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Sick name bro! The name of your farmer will be " + Name + "\nHave fun living life as a farmer!!! ~");
            Console.ReadKey();
            Console.Clear();
        }

        // to move the player on the grid
        public static void ChangeLocation()
        {
            // stops the game if 18 days have passed
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintInventory();
            Data.ShowReputation();
            Console.WriteLine("{0} days have passed since you have left your hometown.\nYour position on the map is represented by the X below.", Days);
            Console.ResetColor();
            Data.ShowMap();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are at the location {0},{1}: would you like to move North, South, East, or West?", XPosition, YPosition);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string Input = Console.ReadLine();
            string LowInput = Input.ToLower();

            // need to make sure that the player cannot move out of the bounds of the grid
            if ((LowInput == "south") && (YPosition + 1 < 3))
            {
                YPosition += 1;
            }
            else
            {
                if ((LowInput == "north") && (YPosition - 1 > -1))
                {
                    YPosition -= 1;
                }
                else
                {
                    if ((LowInput == "east") && (XPosition + 1 < 3))
                    {
                        XPosition += 1;
                    }
                    else
                    {
                        if ((LowInput == "west") && (XPosition - 1 > -1))
                        {
                            XPosition -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Invalid response. You are either on the edge of the map or did not correctly enter a direction.\nPress enter to retry. ~");
                            Console.ReadKey();
                            Console.Clear();
                            Move();
                        }
                    }
                }
            }

            Days++;
            Location destination = Game.Map[YPosition, XPosition];
            Console.Clear();
            destination.Enter();
        }

        // checks to see if 18 days have passed yet and if they have you cant move
        public static void Move()
        {
            if (Days >= 18)
            {
                Game.EndGame();
                Console.ReadKey();
            }
            else
            {
                Console.ResetColor();
                ChangeLocation();
            }
        }

        // the method used to handle the dialogue used in the talk method
        public static void TalkHandler(Character character, int inputnum)
        {
            if ((0 <= inputnum) && (inputnum <= 3))
            {
                character.ShowDialogue(inputnum);
            }

            if (inputnum == 4)
            {
                character.GiveItem(character.NeedItem);
            }

            // hide character mood until the end of the game
            if (inputnum == 1 || inputnum == 2)
            {
                character.AffectCharacter(1);
            }
            else
            {
                if (inputnum == 2)
                {
                    character.AffectCharacter(-1);
                }
                else
                {
                    character.AffectCharacter(0);
                }
            }

            if (character.Mood > 2)
            {
                Reputation++;
            }
            else
            {
                return;
            }

            if (character.Mood < 0)
            {
                Reputation--;
            }
            else
            {
                return;
            }
        }

        // the method used to talk to characters
        public static void Talk(Character character)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Want to talk to this person? There are different conversation options.\nPlease type in the number for the option you want. ~");
            Console.WriteLine("0: Just say hi or something similar. 1: Maybe they need something? 2: Random convo topic. 3: Random convo topic. 4: Give them something.");
            string input = Console.ReadLine();
            Console.Clear();

            // the following code was taken from the StackOverflow thread, "How to convert string to integer in C sharp", in the reply by user devuxer on February 26, 2010
            // https://stackoverflow.com/questions/2344411/how-to-convert-string-to-integer-in-c-sharp

            try
            {
                int inputnum = int.Parse(input);
                TalkHandler(character, inputnum);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Type in an integer ONLY, we don't take letters in this game. ~");
                Console.ReadKey();
                Talk(character);
            }

            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        // to add an item to the players inventory 
        public static void AddItem(string item)
        {
            Inventory.Add(item);
        }

        public static void PrintInventory()
        {
            Console.WriteLine("{0}'s current belongings:", Name);

            foreach (string i in Inventory)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------");
        }
    }
}
