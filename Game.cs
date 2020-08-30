using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Game
    {
        string CombineWords(string word1, string word2 )
        {
            string result = word1 + word2;
            return result;
        }

        int SumTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        void Changename(string oldName, string newName)
        {
            oldName = newName;
        }
        void PrintStats(string name, float health, int damage, int level, string role)
        {
            Console.WriteLine("Player Name: " + name);
            Console.WriteLine("Player Health: " + health);
            Console.WriteLine("Player Damage: " + damage);
            Console.WriteLine("Player Level: " + level);
            Console.WriteLine("Player Role: " + role);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        public void Run()
        {
            string newWord = CombineWords("Peanut", "butter");
            bool gameOver = false;
            while (!gameOver)
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
                Console.WriteLine("Hello traveler! What is your name?");
                string name = Console.ReadLine();
                string role = "none";
                Console.WriteLine("Welcome " + name + "! ");
                Console.WriteLine("Press 1 for Warrior role");
                Console.WriteLine("Press 2 for Mage role");
                Console.WriteLine("Press 3 for Archer role)");
                char input = ' ';
                Console.WriteLine();
                while (input != '1' && input != '2' && input != '3')
                {
                    input = Console.ReadKey().KeyChar;

                    if (input == '1')
                    {
                        health = 200;
                        damage = 70;
                        role = "Warrior";
                    }
                    else if (input == '2')
                    {
                        damage = 50;
                        health = 120;
                        role = "Mage";
                    }
                    else if (input == '3')
                    {
                        damage = 20;
                        health = 100;
                        role = "Archer";
                    }
                    else
                    {
                        Console.WriteLine("Invaild input. Using default stats");
                    }
                }
                Console.WriteLine("You're a " + role + ",interesting traveler.");
                Console.WriteLine("Player Name: " + name);
                Console.WriteLine("Player Health: " + health);
                Console.WriteLine("Player Level: " + level);
                Console.WriteLine("Player Role: " + role);
                Console.WriteLine("Player Damage: " + damage);
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
                ///Prints player stats
                //PrintStats(name, health, damage, level, role);
                //Changename(name, "New Name");
                //PrintStats(name, health, damage, level, role);
                //Console.Clear();

                //First decision
                Console.WriteLine("Stranger you mind helping me with something.");
                Console.WriteLine("Press 1 for Yes");
                Console.WriteLine("Press 2 for No");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    string creatureName = "Creature";
                    float creatureHealth = 100.0f;
                    int creatureDamage = 15;

                    Console.WriteLine("I live on a farm over there.");
                    Console.WriteLine("There is a creature attacking my animals and eating my crops.");
                    Console.WriteLine("I tried fighting the creature, but it was too strong for me");
                    Console.WriteLine("I ran off and hoping to find someone to help me.");
                    Console.WriteLine("Please kill this creature and be careful.");
                    Console.WriteLine("You went to the farm and found the creature.");
                    Console.WriteLine("You challenge the creature.");
                    while (health > 0 && creatureHealth > 0)
                    {
                        Console.WriteLine("Player Name: " + name);
                        Console.WriteLine("Player Role: " + role);
                        Console.WriteLine("Player Health: " + health);
                        Console.WriteLine("Player Damage: " + damage);
                        //Enemy stats:
                        Console.WriteLine("Creature Name: " + creatureName);
                        Console.WriteLine("Creature Health: " + creatureHealth);
                        Console.WriteLine("Creature Damage: " + creatureDamage);
                        Console.WriteLine("\n1)Attack");
                        Console.WriteLine("2)Try to make peace.");

                        char choice = Console.ReadKey().KeyChar;

                        Console.Clear();

                        if (choice == '1')
                        {
                            Console.WriteLine("You attacked the creature.\n" + damage);
                            creatureHealth -= damage;

                        }
                        else if (choice == '2')
                        {
                            Console.WriteLine("\ncreature doesn't what you are trying to do.");
                        }

                        health -= creatureDamage;
                        Console.WriteLine("He clawed your face.\n" + creatureDamage);
                        Console.ReadKey();
                        Console.Clear();

                        if (health <= 0)
                        {
                            health = 0;
                            gameOver = true;
                            break;
                        }

                        if(creatureHealth <= 0)
                        {
                            creatureHealth = 0;
                        }
                    }
                }
                
                {

                    Console.WriteLine(" You Won loser! ");
                    Console.WriteLine("Thank you stranger");




                }


            }
        }
        
    }
}