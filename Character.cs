using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFarmos
{
    public class Character
    {
        public string Name;
        public string Description;
        public string Item;
        public string NeedItem;
        public string[] Dialogue;
        public string[] TalkLines;
        public int Mood = 0;

        public Character()
        {

        }

        public Character(string _name, string _description, string[] _dialogue, string[] _talklines)
        {
            Name = _name;
            Description = _description;
            Dialogue = _dialogue;
            TalkLines = _talklines;
        }

        public Character(string _name, string _description, string[] _dialogue, string[] _talklines, string _needitem)
        {
            Name = _name;
            Description = _description;
            NeedItem = _needitem;
            Dialogue = _dialogue;
            TalkLines = _talklines;
        }

        public Character(string _name, string _description, string _item, string[] _dialogue, string[] _talklines)
        {
            Name = _name;
            Description = _description;
            Item = _item;
            Dialogue = _dialogue;
            TalkLines = _talklines;
        }

        // describe the character and name of the area
        public void DescribeCharacter()
        {
            Console.WriteLine("In Los Farmos, someone starts walking towards you. Get ready to interact.\nThis individual goes by the name of {0}.", Name);
            Console.WriteLine(Description);
            Console.ReadKey();
        }

        // show the characters dialogue of index value
        public void ShowDialogue(int value)
        {
            //Console.WriteLine("You then say: \"{0}\"", TalkLines[value]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Dialogue[value]);
        }

        // method for amber's quiz
        public void ItemTest()
        {
            Console.WriteLine("Please give this stack of money to this person, I just have a question about them. ~");
            Console.ReadKey();
            Console.WriteLine("Who is the owner of the widely popular furniture and used goods store? Hint, the answer is mac.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            string lowinput = input.ToLower();
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (lowinput == "mac")
            {
                Console.WriteLine("Wow, you got that right dude!");
                Console.WriteLine("Here, have this {0}", Item);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You have acquired a {0}! ~", Item);
                Console.WriteLine("---------------------------------------------");
                Player.AddItem(Item);
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is incorrect, but I am not surprised.");
                Console.WriteLine("Come back here soon and I will ask you that same quesiton.\nIf you get it incorrect, there will be consequences! ~");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // get an item from a character
        public void GetItem()
        {
            if ((Item != null) && !(Player.Inventory.Contains(Item)))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" {0} wants to ask you something, if you don't mind:", Name);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please take this, this is very important.");

                if (Player.Reputation < 0)
                {
                    Console.WriteLine("I am not too sure if I should give you this, but I am going to anyways.\nIncrease your karma, and I just MIGHT think about lending this to you.");
                }
                else
                {
                    ItemTest();
                }
            }
            else
            {
                return;
            }
        }

        // has the player give the item to the character
        public void GiveItem(string item)
        {
            if ((NeedItem == item) && (Player.Inventory.Contains(item)))
            {
                this.ShowDialogue(4);

                if (item == "Money")
                {
                    Player.DeliveredMoney = true;
                    Player.Inventory.Remove(item);
                }

                if (item == "Groceries")
                {
                    Player.DeliveredGroceries = true;
                    Player.Inventory.Remove(item);
                }

                if (item == "Bait")
                {
                    Player.DeliveredBait = true;
                    Player.Inventory.Remove(item);
                }
            }
            else
            {
                Console.WriteLine("{0} said that they do need need anything that you have, oops! Sorry dude!", Name);
            }
        }

        public void Interact()
        {
            // reference to the instance of the character. Asking if you want to talk with them now or later, giving them an option.

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Would you like to speak with {0}? If you do not speak with them now, you can still do so later.\nPlease type yes or no. ~", Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            string lowinput = input.ToLower();

            if (lowinput == "yes")
            {
                Console.Clear();
                Player.Talk(this);
            }
            else
            {
                if (lowinput == "no")
                {
                    Console.WriteLine("You chose to talk with them later, have fun in Los Farmos. ~");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please repeat what you said, as I did not catch that. ~");
                    Console.ReadKey();
                    Interact();
                }
            }
        }

        public void AffectCharacter(int value)
        {
            Mood = Mood + value;
        }
    }
}
