using Project_Udemy.Enums;
using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Armors.Heavy;
using Project_Udemy.Equipments.Weapons;
using Project_Udemy.Equipments.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Udemy.Characters.Melee
{
    public abstract class Knight : Character
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
        private Chainlink bodyArmor;
        private Hammer weapon;

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
            this.HealthPoints = healthpoints;
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

        public int HolyBlow()
        {
            throw new NotImplementedException();
        }
        public int PurifySoul()
        {
            throw new NotImplementedException();
        }
        public int RigtheousWings()
        {
            throw new NotImplementedException();
        }

        public override int SpecialAttack()
        {
            return this.HolyBlow();
        }
        public override int Attack()
        {
            return this.PurifySoul();
        }
        public override int Defend()
        {
            return this.RigtheousWings();
        }
        
    }

}


