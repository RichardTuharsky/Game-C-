

using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Weapons;

namespace Project_Udemy.Characters.Spellcasters
{
    public class Mage
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 120;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const string DEFAULT_NAME = "Shaman";

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private string v1;
        private int v2;
        private Staff weapon;
        private ClothRobe bodyArmor;
        public static Action DEFAULT_FACTION1 => DEFAULT_FACTION;

        public int AbilityPoints
        {
            get
            {
                int abilityPoints = 0;
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    int abilityPoints = value;
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
                int healthPoints = 0;
                return healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    int healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }

        public int Level
        {
            get
            {
                int level = 0;
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    int level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
        }

        public string Name
        {
            get
            {
                string name = null;
                return name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    string name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
        }


        public Faction Faction
        {
            get
            {
                Faction faction = null;
                return faction;
            }
            set
            {
                this.Faction = value;
            }
        }
        public ClothRobe BodyArmor
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

        public Staff Weapon
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

        public Mage()
            : this("Juro", 1)
        {

        }

        public Mage(int level, int healthpoints, int abilitypoints)
        {
            this.Name = DEFAULT_NAME;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = abilitypoints;
            this.Faction = DEFAULT_NAME;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Mage(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}

    
           
    }
}
