using System;
using MagicDestroyer.Equipment.Armors;
using MagicDestroyer.Equipment.Weapons;

namespace MagicDestroyer.Characters.Melee
{
    class Knight
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private ChainLink bodyArmor;
        private Hammer weapon;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 120");
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
                if (value >= 0 && value <= 30)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 30");
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
                if (value > 0 && value <= 10)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be > 0 and <= 10");
                }
            }
        }

        public string Faction
        {
            get => faction;
            set
            {
                if (value == "Melee" || value == "SpellCaster")
                {
                    value = faction;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The faction need to be Melee or SpellCaster");
                }
            }
        }
        public string Name 
        { 
            get => name;
        set
        {
            if(value.Length >= 4 && value.Length <= 15)
            {
                value = name;
            }
            else
            {   
                throw new ArgumentOutOfRangeException(string.Empty, "The name shhould be between 4 and 15 letters");
            }
        }
        }
        public Knight() //constructor
        {

        }

        public void HolyBlow()
        {
            throw new NotImplementedException();
        }
        public void Purifysoul()
        {
            throw new NotImplementedException();
        }
        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}