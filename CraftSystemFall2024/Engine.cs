using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static CraftSystemFall2024.Library;

namespace CraftSystemFall2024
{
    public class Engine
    {
        private string Name = "Super Awesome Crafting System";
        Person Player = new Person("Player Name");
        Person Vendor = new Person();

        public void Start()
        {
            Print(Name);
            Title = Name;
            Print(Player.About());
        }

        private void SetPlayerName()
        {
            Print("Would you like to change your name? Enter y for yes, n for no:");

            if (GetInput(ReadLine()).ToLower() == "y")
            {
                Print("Enter your name:");
                Player.ChangeName(GetInput(ReadLine()));
            }
        }


        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}