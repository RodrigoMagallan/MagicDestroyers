using System.Security.AccessControl;
using System;
using MagicDestroyer.Equipment.Armors;
using MagicDestroyer.Equipment.Weapons;

namespace MagicDestroyer.Characters.Melee
{
    class Assasin
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Sword weapon;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 200");
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
        public Assasin() //constructor
        {

        }
        public void Raze()
        {
            throw new NotImplementedException();
        }
        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }
        public void survival()
        {
            throw new NotImplementedException();
        }
    }
}