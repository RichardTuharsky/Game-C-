using Project_Udemy.Enums;
using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Armors.Leather;
using Project_Udemy.Equipments.Weapons;
using Project_Udemy.Equipments.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Udemy.Characters.Melee
{
    public abstract class Assasin : Character
    {
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const string DEFAULT_NAME = "Sura";

        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();
     
        private string v1;
        private int v2;

        private Sword weapon;
        private LightLeatherVest bodyArmor;
   
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

        public static Faction DEFAULT_FACTION1 => DEFAULT_FACTION;

        public Assasin()
            : this("Sura", 1)
        {

        }
        public Assasin(int level, int healthpoints, int abilitypoints)
        {
            this.Name = DEFAULT_NAME;
            this.Level = level;
            this.HealthPoints = healthpoints;
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

        public int Raze()
        {
            throw new NotImplementedException();
        }
        public int BleedToDeath()
        {
            throw new NotImplementedException();
        }
        public int Survival()
        {
            throw new NotImplementedException();
        }
        public override int SpecialAttack()
        {
            return this.Raze();
        }
        public override int Attack()
        {
            return this.BleedToDeath();
        }
        public override int Defend()
        {
            return this.Survival();
        }
    }
}
