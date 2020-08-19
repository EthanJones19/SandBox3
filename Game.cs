using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Health
            float health = 100.0f;
            float healthRegen = 20;
            bool ready = true;
            //Level
            bool maxLevelReached = false;
            int maxLevel = 100;
            int level = 1;
            //Damage
            int damage = 20;
            //Mana
            float mana = 30.0f;
            float manaRegen = 20;
            Console.WriteLine("Hello traveler! What is your name");
            string name = Console.ReadLine();
            string role = "none";
            Console.WriteLine("Welcome " + name + "! ");
            Console.WriteLine("Press 1 for Warrior role");
            Console.WriteLine("Press 2 for Mage role");
            Console.WriteLine("Press 3 for Archer role)");
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                mana = 0;
                health = 200;
                role = "Warrior";
            }
            else if (input == '2')
            {
                mana = 30;
                damage = 40;
                role = "Mage";
            }
            else if (input == '3')
            {
                mana = 0;
                damage = 20;
                role = "Archer";
            }
                Console.WriteLine("Invaild input. Using default stats");
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Mana: " + mana);
        }
    }
}
