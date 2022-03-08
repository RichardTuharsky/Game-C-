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
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const string DEFAULT_NAME = "Sura";

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private int healthPoints;
        private string v1;
        private int v2;
        private Sword weapon;
        private LightLeatherVest bodyArmor;
        private string name;
        private string faction;
        private int abilityPoints;

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
                return this.bodyArmor;
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
            : this("Sura", 1)
        {

        }
        public Assasin(int level, int healthpoints, int abilitypoints)
        {
            this.Name = DEFAULT_NAME;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = abilitypoints;
            this.Faction = DEFAULT_NAME;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Assasin(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
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
