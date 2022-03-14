using Project_Udemy.Enums;
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
       

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();
        private Axe weapon;
        private Chainlink bodyArmor;

        public Warrior()
            : this(Consts.Warrior.NAME, 1)
        {
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


        public Warrior()
            : this ("Bob",1)
        {
           
        }
       
        public Warrior(int level, int healthpoints, int abilitypoints)
        {
            base.Name = DEFAULT_NAME;
            base.Level = level;
            base.HealthPoints = HealthPoints;
            base.AbilityPoints = Consts.Warrior.DEFAULT_ABILITY_POINTS;
            base.Faction = Faction.Melee;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsAlive = true;
            base.Scores = 0;
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
