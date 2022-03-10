using Project_Udemy.Characters.Interfaces;
using Project_Udemy.Enums;
using System;

namespace Project_Udemy.Characters

{
    public abstract class Character : IAttack, IDefend
    {
        private int healthPoints;
        private int level;

        private Faction faction;

        private string name;


     
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 50.")
                }
            }

        }
        private int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 1 and <= 100.");
                }
            }

        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "Male" || value == "Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "The faction should be either male.");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate value , the length of the name should be between 3 and 12 ");
                }
            }
        }


        public abstract void SpecialAttack();
        public abstract void Attack();
        public abstract void Defend();
    }
}