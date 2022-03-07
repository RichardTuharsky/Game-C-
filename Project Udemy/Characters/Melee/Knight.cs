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
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Hammer weapon;

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
        {
            this.name = "Jambo";
            this.level = 1;
            this.healthPoints = 20;
            this.abilityPoints = 78;
            this.bodyArmor = new Chainlink();
            this.weapon = new Hammer();
        }
        public Knight(string name, int level, int healthpoints)
        {
            this.name = "Jambo";
            this.level = 1;
            this.HealthPoints = healthPoints;
            this.abilityPoints = 78;
            this.bodyArmor = new Chainlink();
            this.weapon = new Hammer();
        }
        public Knight(string name, int level, int healthpoints, int abilitypoints)
        {
            this.name = "Jambo";
            this.level = 1;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = abilityPoints;
            this.bodyArmor = new Chainlink();
            this.weapon = new Hammer();
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


