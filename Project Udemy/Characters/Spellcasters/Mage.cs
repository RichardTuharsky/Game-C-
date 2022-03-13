﻿
using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Armors.Light;
using Project_Udemy.Equipments.Weapons;
using Project_Udemy.Equipments.Weapons.Blunt;

namespace Project_Udemy.Characters.Spellcaster
{
    public abstract class Mage : Character
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
            this.HealthPoints = HealthPoints;
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

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public int Fireball()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
        public override int Attack()
        {
            return this.Fireball();
        }
        public override int Defend()
        {
             this.Meditation();
        }
    }
}

    
           
    }
}
