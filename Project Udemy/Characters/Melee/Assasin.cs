using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Udemy.Characters.Melee
{
    public class Assasin
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private LightLeatherVest bodyArmor;
        private Sword weapon;


        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 50");
                }
            }
        }
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Male" || value == "Spellcaster")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "The faction should be either male");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= 3 && value.Length <= 12)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of the name, should be between 3 and 12");
                }
            }
        }

        public int Level { get; }

        public LightLeatherVest BodyArmor
        {
            get
            {
                return this.bodyArmor
            }
            set
            {
                bodyArmor = value;
            }
        }
        
        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Assasin()
        {
            this.Name = "Zoro";
            this.Level = 5;
            this.HealthPoints = 32;
            this.AbilityPoints = 95;
            this.Faction = "Melee";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }
        public Assasin(string name, int level)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = 32;
            this.AbilityPoints = 95;
            this.Faction = "Melee";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }
        public Assasin(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = 95;
            this.Faction = "Melee";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }
        public Assasin(string name, int level, int healthPoints, int abilitypoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = abilityPoints;
            this.Faction = "Melee";
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

        public void Raze()
        {
            throw new NotImplementedException();
        }
        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }
        public void Survival()
        {
            throw new NotImplementedException();
        }

    }
}
