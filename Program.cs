using System;

//Los Farmos, by Gabe Sotomayor
// 10/27/21
// Programming 101
// Midterm Adventure Game Fall 2021
// Credit goes to Karen Spriggs for the template of the game.

namespace LosFarmos
{
    class Program
    {
        static void Main()
        {
            // ASCII art for down below found and used from this website https://ascii.co.uk/art/farms
            string title = @"  
                                Los Farmos by Gabe Sotomayor
+&-                   
                           _.-^-._    .--.
                        .-'   _   '-. |__|
                       /     |_|     \|  |
                      /               \  |
                     /|     _____     |\ |
                      |    |==|==|    |  |
  |---|---|---|---|---|    |--|--|    |  |
  |---|---|---|---|---|    |==|==|    |  |
 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
            Console.WriteLine(title);


            Game.Run();
        }
    }
}

// Credit: Like I said above in the comments, Karen Spriggs gets credit for the template of the game and for giving me helpful tips
// on coding in general during tutoring sessions. 
// Game premise: You are a farmer in a small midwest town called Los Farmos. You play as a customer who trades with farmers,
// customers, and other tradesmen who live in in the same area. You wander around and visit different areas of the place and
// meet many different types of people around the town, visiting shops, farms, and even your local post office. The story begins
// with you, the main customer protagonist, wanting to buy, sell, and acquire different goods, produce, and money to buy, maintain,
// and your new house with furniture, food for your fridge and cabinets, and decorations. You meet interesting people, and some of
// them may ask you to do something or talk to you about themselves.
// Characters: Amber, Jewel, Mac, Rich, and yourself.
// Items: Groceries, money, bait.
// Win condition: if you deliver all of the items back to the locals.
// Variables that track events: there are different methods, arrays, and inventory items that track events, plus many more things
// that I am forgetting.
// 3 variables that impact gameplay: what you type in about answering a local's question, as if you answer it incorrectly, you do must
// come back to them after you get the answer to that question someplace else. Moving either north, south, east, or west
// on the map, as there are X's and O's being the map, as the O represents a place where you can move on the map and the X represents
// where you are on the map, and it can impact the place that you will be going to, with each one being unique. Lastly the last one is
// choosing whether to talk, explore, or go to the map once you reach a certain destination from the map, as each place, person, or 
// place on the map has a different description to them, and each local has different questions and each place has different items that
// you may or may not find.
// Inheritance: Name = _name;
//              Description = _description;
//              Item = _item;
//              ExploreText = _exploretext;
// Inheritance is basing an object or class upon another abject or class, having similar implementation. My project demonstrates my
// understanding of it because I can see the relation of my classes with their objects with their hierarchy's. It makes sense to me
// as there are similar names to it, such as Name and _name, so it makes going back to my code and referencing much easier.
// Polymorphism: TalkHandler(Character character, int inputnum)
// Polymorphism is the method that performs different things as per the object's class that calls it. My project demonstrates my
// understanding by having an object call a certain method, or in this code example, having an integer and a character being called.
// Encapsulation: public static class Player
//                public static class Character
//                public static class Data
//                public static class Game
//                public static class Location
//                              class Program
// Enscapsulation: is used to hide the values or state of a structured data object inside a class, preventing direct access of them
// for unauthorized parties. My project demonstrates my understanding of it by having public properties in my code with the public
// classes being stated in the beginning of each file, as you can have public methods as well if they are void instead.
