using System;

public class Character
{ 
        string name;
        string type;
        int health;
        int weaponEffect;
        int gameCredit;

        public void setName(string newName)
        {
            name = newName;
        }
        public void setType(string newType)
        {
            type = newType;
        }
        public void setHealth(int newHealth)
        {
            health = newHealth;
        }
        public void setWeaponEffect(int newWeaponEffect)
        {
            weaponEffect = newWeaponEffect;
        }
        public void setGameCredit(int newGameCredit)
        {
            gameCredit = newGameCredit;
        }
        public string toString()
        {
            return ("Name: " + name + ", " + "Type: " + type + ", " + "Health: " + health + ", " + "Weapon effect: " + weaponEffect + ", " +"Game Credit: " + gameCredit);
        }
        public void SpendAllGameCredits()
        {

        if (type == "Team Member" & gameCredit > 0)
        {
            Console.WriteLine("Dean, Keizer and Todd do you want to upgrade your weapon effect? y or n");
            string spendcreditsTME = Console.ReadLine();
            if (spendcreditsTME == "y")
            {
                for (int i = 0; gameCredit > 0; i = i + 1)
                {
                    weaponEffect = weaponEffect + 1;
                    gameCredit = gameCredit - 1;
                    Console.WriteLine("Weapon Effect has been increased by 1, Weapon effect is now " + weaponEffect);
                }
                Console.WriteLine("Weapon Effect now equals: " + weaponEffect + " and you have  " + gameCredit + " game credits");
            }
            else
            {
                Console.WriteLine("Credits not Spent");
            }
        }


        else if (type == "Civilian" & gameCredit > 0)
        {
            Console.WriteLine("Eddie do you want to upgrade your health?  y or n");
            string spendcreditsC = Console.ReadLine();
            if (spendcreditsC == "y")
            {                                                                                           // this section of code is the calculation to spend all of the game credits
                for (int i = 0; gameCredit > 0; i = i + 1)
                {
                    health = health + 5;
                    gameCredit = gameCredit - 1;
                    Console.WriteLine("Health has been increased by 5, health is now " + health);
                }
                Console.WriteLine("Health now equals: " + health + " and you have  " + gameCredit + " game credits");
            }
            else
            {
                Console.WriteLine("Credits not Spent");
            }
        }
        else
        {
            Console.WriteLine("Credits not Spent");
        }
            }

        }
        


    



