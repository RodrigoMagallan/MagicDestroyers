using System;
using MagicDestroyer.Equipment.Weapons;
using MagicDestroyer.Equipment.Armors;

namespace MagicDestroyer.Characters.Spellcasters
{
    class Druid
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string faction;
        private string name;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 130");
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
                if (value >= 0 && value <= 10)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 10");
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
                if (value.Length >= 4 && value.Length <= 15)
                {
                    value = name;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The name shhould be between 4 and 15 letters");
                }
            }
        }
        private LightLeatherVest bodyArmor;
        private Staff weapon;
        public Druid()//constructor
        {

        }
        public void MoonFire()
        {
            throw new NotImplementedException();
        }
        public void Starbust()
        {
            throw new NotImplementedException();
        }
        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}