using Project_Udemy.Characters;
using Project_Udemy.Characters.Melee;
using Project_Udemy.Characters.Spellcaster;
using System;
using System.Collections.Generic;


namespace Project_Udemy
{
    class EntryPoint
    {
        static void Main()
        {
            Character warrior = new Warrior();
            Character knight = new Knight();    
            Character assasin = new Assasin();
            Character mage = new Mage();
            Character druid = new Druid();
            Character necromancer = new Necromancer();


            List<Character> meleeTeam = new List<Character>();
            List<Character> spellTeam = new List<Character>();

            meleeTeam.Add(warrior); 
            meleeTeam.Add(knight);
            meleeTeam.Add(assasin);

            spellTeam.Add(mage);
            spellTeam.Add(necromancer);    
            spellTeam.Add(druid);

        }
    }
}
