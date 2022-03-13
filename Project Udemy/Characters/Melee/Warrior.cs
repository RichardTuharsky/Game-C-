using Project_Udemy.Equipments.Armors;
using Project_Udemy.Equipments.Armors.Heavy;
using Project_Udemy.Equipments.Weapons;
using Project_Udemy.Equipments.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Udemy.Characters.Melee
{
    public abstract class Warrior : Character
    { 
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 120;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const string DEFAULT_NAME = "Bob";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private string v1;
        private int v2;
        private Axe weapon;
        private Chainlink bodyArmor;

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

        public Axe Weapon
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

        public static Action DEFAULT_FACTION1 => DEFAULT_FACTION;

        public Warrior()
            :this("Bob",1)
        {
           
        }
       
        public Warrior(int level, int healthpoints, int abilitypoints)
        {
            this.Name = DEFAULT_NAME;
            this.Level = level;
            this.HealthPoints = HealthPoints;
            this.AbilityPoints = abilitypoints;
            this.Faction = DEFAULT_NAME;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public Warrior(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Strike()
        {
            return - base.Weapon.DamagePoints + 10;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }
        public override int Attack()
        {
            return this.Strike();
        }
        public override int Defend()
        {
            return this.SkinHarden();
        }
       
    }
}
