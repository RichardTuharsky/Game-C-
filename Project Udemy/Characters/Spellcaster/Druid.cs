using Project_Udemy.Enums;
using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Udemy.Characters.Spellcaster
{
    public abstract class Druid : Character
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 120;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const string DEFAULT_NAME = "Lama";

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private LightLeatherVest bodyArmor;
        private Staff weapon;

        private string v1;
        private int v2;

        
        public LightLeatherVest BodyArmor
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
        public static Action DEFAULT_FACTION1 => DEFAULT_FACTION2;

        public static Faction DEFAULT_FACTION2 => DEFAULT_FACTION3;

        public static Faction DEFAULT_FACTION3 => DEFAULT_FACTION;

        public Druid()
            : this("Bob", 1)
        {

        }

        public Druid(int level, int healthpoints, int abilitypoints)
        {
            this.Name = DEFAULT_NAME;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.AbilityPoints = abilitypoints;
            this.Faction = DEFAULT_NAME;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Druid(string v1, int v2)
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

    
           
    



  