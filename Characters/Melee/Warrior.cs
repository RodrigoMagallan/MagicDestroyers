using System;
using MagicDestroyer.Equipment.Armors;
using MagicDestroyer.Equipment.Weapons;

namespace MagicDestroyer.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        private ChainLink bodyArmor;
        private Axe weapon;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 100");
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
                if (value >= 0 && value <= 20)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 20");
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
                if(value > 0 && value <= 10)
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
        public Warrior() //Constructor
        {

        }
        public void Strike()
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
        public void SkinHarder()
        {
            throw new NotImplementedException();
        }
    }
}