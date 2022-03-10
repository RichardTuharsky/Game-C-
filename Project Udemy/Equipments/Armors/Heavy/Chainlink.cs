using System;


namespace Project_Udemy.Equipments.Armors.Heavy
{
    public class Chainlink : Heavy
    {
        private const int DEFAULT_ARMOR_POINTS = 10;

        public Chainlink()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }

        public Chainlink(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
