using Project_Udemy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Udemy
{
    public static class Consts
    {   

        public static class Warrior
        {
            public const int LEVEL = 1;
            public const int ABILITY_POINTS = 120;
            public const Faction FACTION = Faction.Melee;
            public const int HEALTH_POINTS = 50;
            public const string NAME = "Bob";
        }
        public static class Mage
        {
            private const int LEVEL = 1;
            private const int MANA_POINTS = 120;
            private const Faction FACTION = Faction.Spellcaster;
            private const int HEALTH_POINTS = 50;
            private const string NAME = "Roko";
        }

    }
}
