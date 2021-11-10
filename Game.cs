using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFarmos
{
    public static class Game
    {
        // the title of the game
        public static string Title = "Los Farmos, by Gabriel Sotomayor";

        // the game characters and locations, giving some description of the characters and of the locations.

        public static Character Mac = new Character("Mac.", "He is a shop owner and manager of 'MacPlace'. He sells furniture and used belongings.\nAll day, he wanders around his shop, helping out locals with anything.", Data.MacDialogue, Data.MacTalk, "Money");
        public static Character Amber = new Character("Amber.", "She is a beautfiul brunette in the town, and is an avid fan of October. \nShe is well liked all around the area, and is one of the best farmers in town. ", "Money", Data.AmberDialogue, Data.AmberTalk);
        public static Character Jewel = new Character("Jewel.", "She is the local weirdo. Everyone in town seems like there is always something suspicious with her..\nShe loves shopping for the best used and new goods.", Data.JewelDialogue, Data.JewelTalk, "Groceries");
        public static Character Rich = new Character("Rich.", "He is a favorite of Los Farmos. His expertise is selling delicious mangos.\nHe is a helpful trader, and he does community service for Los Farmos.", Data.RichDialogue, Data.RichTalk, "Bait");
        public static Location Postoffice = new Location("Post Office.", "the one and only post office in the entire town of Los Farmos.\nMany people come here to ship out gifts, send letters, or to return messed up orders by Amazon.",
                                                    "You walk into the welcoming post office, there are lights everywhere inside.\nYou find money on the ground to give to Mac.", "Groceries");
        public static Location Capital = new Location("Capital Building.", "a capital building that has interesting architecture.\nThere are many politicians having a state wide meeting there, as there is political talk there.",
                                                   "You become scared, as you are apporached by a politician near the sidewalk.\nYou decide to run, as you do not have time for any broken promises.");
        public static Location Macplace = new Location("MacPlace.", "a huge store that has everything that you ever need to live.\nThe furniture is state-of-the-art, and it made of high quality material.",
                                                        "You see a nice looking white couch, and walk over it, enjoying the entire store.", Mac);
        public static Location Animalarea = new Location("Animal Area.", "a place where lost and wandering pets and animals stay at.\nThe place is well known for taking great care of animals, providing shelter, food, love, and care by workers.",
                                                     "You see a super cute kitten from across the way, and you run over there to pick it up.", Amber);
        public static Location Farmocado = new Location("Farmocado.", "a Mexican restaurant that has delicious food.\nThe place is well known for their tacos and desserts, and it a local favorite.",
                                                     "You walk in and grab a table, sitting yourself down.\nYou look at the menu, and everything sounds so yummy at the moment.");
        public static Location College = new Location("College.", "a small community college that is the only college in the area.\nThere have been many high-profile locals to go to school there.", "Groceries",
                                                   "You walk through the campus, having thoughts about attending.\nIn walking around campus, you find bait in a trashbin for Rich!", Jewel);
        public static Location Farmland = new Location("Farmland.", "a collection of different farms that stretch many acres.\nThere are at least a dozen different farmers, and this is where most farms are located.",
                                                     "You wander about, checking out the different cattle, crops, and flowers everywhere.");
        public static Location Crystallake = new Location("Crystal Lake.", "an area near a forest in the middle of Los Farmos.\nIt is known for creepy and spooky stories, as the place has a cult following.",
                                                        "You decide to walk over by the lake and start exploring.\nYou then find a bag of groceries near a tree, and pick it up.\nIt feels heavy, as you have an inclination to give it to someone.", "Bait");
        public static Location Richshop = new Location("Rich's Farm Shop.", "a surprisingly big food shop in the area.\nYou walk in and see so many rich (no pun intended) and beautiful colors of fruit,\nand you notice a perfectly shaped and ripe mango from the corner of your eye.",
                                                           "You pick up the mango, and begin to stare at it for some time, admiring it.", Rich);

        public static Location[,] Map = new Location[3, 3];

        // this method sets up the map array to have all of the correct values in the correct places
        public static void SetUpMap()
        {
            Map[0, 0] = Postoffice;
            Map[0, 1] = Macplace;
            Map[0, 2] = Capital;
            Map[1, 0] = College;
            Map[1, 1] = Animalarea;
            Map[1, 2] = Crystallake;
            Map[2, 0] = Farmocado;
            Map[2, 1] = Farmland;
            Map[2, 2] = Richshop;
        }

        // sets the console window title to the title of the game
        public static void SetTitle()
        {
            Console.Title = Title;
        }

        // contains and prints the prologue onto the screen for the player to read
      
        public static void PrologueText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} is you, the main character. Welcome to the midwest small town of Los Farmos, {0}.", Player.Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}, you will meet new people, sell, buy, and trade with other farmers, and just explore this great area, {0}.", Player.Name);
            Console.WriteLine("While you spend 2 and a half weeks here, please have lots of fun in meeting some of our lovely townsfolk here in Los Farmos!");
            Console.WriteLine("After each interaction of talking, exploring, or going to the map, a day will pass by. You will spend 18 days here.");
            Console.WriteLine("We have amazing people in each of our farms, our restaurants, bars, shops, and even in our local post office.");
            Console.WriteLine("You can buy your own furniture, own your own place, whether it be a farm or a home, and acquire different goods.");
            Console.WriteLine("Collect items by exploring places, and then give those items to their respected owners.");
            Console.WriteLine("After 18 days, the game will end, showing you what you did, your reputation, and the items you found.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Have a great time meeting everyone here at beautiful Los Farmos! ~");
            Console.ReadKey();
            Console.Clear();
        }

        // starts the game
        public static void Start()
        {
            SetUpMap();
            SetTitle();
            Player.NamePlayer();
            // to test out the character descriptions
            PrologueText();
        }

        // this method handles the best ending
        public static void BestEnding()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("During your 18 day visit to Los Farmos, you gathered many materials and supplies!");
            Console.WriteLine("You go shopping to get produce, crops, and furniture to use in your house.");
            Console.WriteLine("The friends that you made along the way have a special place in your heart.");
            Console.WriteLine("---");
            Console.WriteLine("You set up your house with your new goodies, and it looks amazing!");
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You walk back into town after setting up your house and farm.");
            Console.WriteLine("The post office worker says 'hello, {0}! We are so glad to see you again!'", Player.Name);
            Console.WriteLine("You see Rich selling mangos on the corner, having the time of his life selling fruit.");
            Console.WriteLine("Across the street is the animal care area, and you see the great things they are doing there.");
            Console.WriteLine("And once again, you see Mac sell some great couches! They are made of pure leather!");
            Console.WriteLine("---");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You then ponder and think about what a beautiful little town that this is.");
            Console.WriteLine("Finally, you realize that you made many friends of all different types, and you are happy.");
        }

        // this method determines what the player sees if they did not get the best ending
        public static void Endings()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eighteen days have now passed, and you are now back in your hometown, sad because you miss everyone.");

            if (Player.DeliveredMoney)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You successfully delivered the money to store owner Mac.\nHe can now pay off his store for the next couple months, thanks!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You did not deliver the money to Mac...\nthink about doing that next time you see him, aight?.");
            }

            Console.ResetColor();

            if (Player.DeliveredGroceries)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You found the groceries in the forest. You returned them to their rightful owner!\nThey congratulated you by making you a homemade meal. Yummy alfredo pasta!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You did not find the bag of groceries on the ground...\nmawkward, you should find it next time.");
            }

            Console.ResetColor();

            if (Player.DeliveredBait)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You found Rich's bait, and now you gave it back to him. How nice!\nHe can now continue to run his successful mango shop.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You did not deliver the bait to Rich...\nhe really needed your help, you let Rich down. Nice one.");
            }

            Console.ResetColor();

            if (Player.Reputation > 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("People love you! You have made many friends here in Los Farmos! Great work!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Well, it looks like people do NOT care for you. They do NOT like you...\nnobody likes a person who is not friendly. Try better next time.");
            }

            Console.ResetColor();
        }

        // this method determines the ending that the player gets
        public static void EndGame()
        {
            if ((Player.DeliveredMoney == true) && (Player.DeliveredBait == true) && (Player.DeliveredGroceries == true) && (Player.Reputation > 1))
            {
                BestEnding();
            }
            else
            {
                Endings();
            }


            Console.WriteLine("~");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You have finished Los Farmos, please come back anytime!");
            Console.ReadKey();
        }

        // handles the actual gameplay loop
        public static void Play()
        {
            Player.Move();
        }

        // runs the game
        public static void Run()
        {
            Start();
            Play();
        }
    }
}
