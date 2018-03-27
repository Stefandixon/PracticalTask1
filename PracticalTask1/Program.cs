using System;

namespace PracticalTask1
{
    enum characters {character1, character2, character3, character4 };
    class Program
    {
        

        
        static void Main(string[] args)
        {
            Character character1 = new Character();
            Character character2 = new Character();
            Character character3 = new Character();             // creating the 4 characters
            Character character4 = new Character();

            character1.setName("DeanKeaton");
            character1.setType("Team Member");                  // Giving the objects elements
            character1.setHealth(15);
            character1.setWeaponEffect(4);
            character1.setGameCredit(5);

            character2.setName("Keizer Soze");
            character2.setType("Enemy");
            character2.setHealth(100);
            character2.setWeaponEffect(2);
            character2.setGameCredit(15);

            character3.setName("Todd Hockney");
            character3.setType("Team Member");
            character3.setHealth(25);
            character3.setWeaponEffect(2);
            character3.setGameCredit(10);

            character4.setName("Eddie Finneran");
            character4.setType("Civilian");
            character4.setHealth(90);
            character4.setWeaponEffect(0);
            character4.setGameCredit(30);

            Console.WriteLine("******* Welcome to fps Extreme *******");
            Console.WriteLine("The Characters in this game are: ");
            Console.WriteLine(character1.toString());
            Console.WriteLine(character2.toString());
            Console.WriteLine(character3.toString());           // printing the characters and attributes
            Console.WriteLine(character4.toString());
                                                        
            character1.SpendAllGameCredits();
            character4.SpendAllGameCredits();                   // applying the spend method


        }
    }
}
