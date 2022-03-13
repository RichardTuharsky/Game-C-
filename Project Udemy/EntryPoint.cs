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
            Random rng = new Random();
            int currentMelee = 0;
            int currentSpellCaster = 0;
            bool gameOver = false;
            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assasin(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach(var character in characters)
            {
                if(character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while(!gameOver)
            {   
                currentMelee = rng.Next(0,meleeTeam.Count);
                currentSpellCaster = rng.Next(0,spellTeam.Count);
                //Take a random melee
                //Take a ranodm spellcaster
                spellTeam[currentSpellCaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);
                if (!spellTeam[currentSpellCaster].IsAlive)
                {
                    spellTeam.Remove(spellTeam[currentSpellCaster]);
                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins");
                        break;
                    }
                    else
                    {
                        currentSpellCaster = rng.Next(0, spellTeam.Count);
                    }

                }
              
                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellCaster].Attack(), spellTeam[0].Name);
                if(!meleeTeam[currentMelee].IsAlive)
                {
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if(meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellCaster = rng.Next(0, spellTeam.Count);
                    }
                }
                //Spellcaster attacks melee
            }

        }
    }
}
