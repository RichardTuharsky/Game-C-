using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Udemy.Characters.Melee
{
    public class Knight
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const string DEFAULT_NAME = "Wick";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private string v1;
        private int v2;
        private int healthPoints;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
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
                    throw new ArgumentOutOfRangeException(string.Empty, "You are getting out of health");
                }
            }
            
        }
        public int Level
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
                    throw new ArgumentOutOfRangeException(string.Empty, "Level");
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
                    throw new ArgumentException(string.Empty);
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
                    throw new ArgumentException(string.Empty, "Innaproportiate length of name should be between 3 and 12 characters.");
                }
            }

        }
        public Chainlink BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }

        public Hammer Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Knight()
            :this("Jambo", 1)
        {
         
        }
        public Knight(int level, int healthpoints, int abilitypoints)
        {
            this.Name = DEFAULT_NAME;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = abilitypoints;
            this.Faction = DEFAULT_NAME;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }
        public Knight(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }
        public void RigtheousWings()
        {
            throw new NotImplementedException();
        }

    }

}


