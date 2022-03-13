using Project_Udemy.Characters.Interfaces;
using Project_Udemy.Enums;
using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Weapons;
using System;

namespace Project_Udemy.Characters

{
    public abstract class Character : IAttack, IDefend
    {
        private int healthPoints;
        private int level;

        private Faction faction;

        private string name;

        private Weapon weapon;
        private Armor bodyArmor;

        private bool isAlive;

        private int scores;

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
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

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            private set
            {
                this.isAlive = value;
            }
        }

        public int Scores
        {
            get
            {
                return this.scores;
            }
            private set
            {
                this.scores = value;
            }
        }
        public abstract int SpecialAttack();
        public abstract int Attack();
        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            if(this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();
                if(this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("You are weak, it was nothing to me!");
            }

            if(!this.IsAlive)
            {
                Console.WriteLine($"{this.name} received {damage} from {attackerName} damage, and is now dead!");
            }
            else
                Console.WriteLine($"{this.name} received {damage} from {attackerName} damage, and now has {this.healthPoints}");
        }
    }
}