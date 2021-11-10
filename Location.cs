using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFarmos
{
    public class Location
    {
        public string Name;
        public string Description;
        public string Item;
        public string ExploreText;
        public Character Resident;

        public Location()
        {

        }

        // this is if the location does not have a character in it
        public Location(string _name, string _description, string _exploretext)
        {
            Name = _name;
            Description = _description;
            ExploreText = _exploretext;
        }

        // this is if the location does not have a character in it but has an item
        public Location(string _name, string _description, string _exploretext, string _item)
        {
            Name = _name;
            Description = _description;
            Item = _item;
            ExploreText = _exploretext;
        }

        // this is if the location has a character in it
        public Location(string _name, string _description, string _exploretext, Character _resident)
        {
            Name = _name;
            Description = _description;
            ExploreText = _exploretext;
            Resident = _resident;
        }


        // this is if the location has a character in it and an item
        public Location(string _name, string _description, string _item, string _exploretext, Character _resident)
        {
            Name = _name;
            Description = _description;
            Item = _item;
            ExploreText = _exploretext;
            Resident = _resident;
        }

        // describes the location
        public void DescribeLocation()
        {
            Console.WriteLine("You have now arrived at the " + Name + "\nYou see before you " + Description);
            Console.ReadKey();
        }

        // where the player finds an item if the location has one, and has cute and colorful text
        public void Explore()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(ExploreText);

            if (Item != null)
            {
                Player.AddItem(Item);
            }
            else
            {
                Console.WriteLine("Yo, please keep on searching somewhere else. There is NOTHING here!\nYou will probably have better luck somewhere else. Keep on looking, yo! ~");
            }

            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        public void TalkCheck()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Want to explore this place more at {0}, speak to {1} again, or go to a different place from the map?\nPlease answer either explore, talk, or map. ~", Name, Resident.Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            string lowinput = input.ToLower();

            if (lowinput == "explore")
            {
                Explore();
            }
            else
            {
                if (lowinput == "map")
                {
                    Console.WriteLine("You want to check out a different spot. ~");
                    Console.ReadKey();
                    Console.Clear();
                    Player.Move();
                }
                else
                {
                    if (lowinput == "talk")
                    {
                        Console.WriteLine("You want to speak to {0} again. ~", Resident.Name);
                        Console.ReadKey();
                        Console.Clear();
                        Resident.Interact();
                    }
                    else
                    {
                        Console.WriteLine("Repeat that, you were not clear. Speak up. ~");
                        Console.ReadKey();
                        Console.Clear();
                        TalkCheck();
                    }
                }
            }

            Console.ReadKey();
            TalkCheck();

        }

        // checks to see what the player wants to do next
        public void OptionCheck()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Want to go to this place {0} or check out a different spot from the map?\nSay either explore or map, please. ~", Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            string lowinput = input.ToLower();

            if (lowinput == "explore")
            {
                Explore();
            }
            else
            {
                if (lowinput == "map")
                {
                    Console.WriteLine("You want to check out a different spot. ~");
                    Console.ReadKey();
                    Console.Clear();
                    Player.Move();
                }
                else
                {
                    if (lowinput == "talk")
                    {
                        Console.WriteLine("Again, please repeat yourself and speak up. ~");
                        Console.ReadKey();
                        Console.Clear();
                        OptionCheck();
                    }
                }
            }

            Console.ReadKey();
            OptionCheck();
        }

        public void Check()
        {
            if (Resident != null)
            {
                TalkCheck();
            }
            else
            {
                OptionCheck();
            }
        }

        // the "main menu"
        public void Menu()
        {
            Console.ResetColor();
            Check();
        }

        public void Enter()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            DescribeLocation();

            if (Resident != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Resident.DescribeCharacter();
                Resident.GetItem();
                Resident.Interact();
            }

            Console.ResetColor();
            Check();
        }
    }
}
