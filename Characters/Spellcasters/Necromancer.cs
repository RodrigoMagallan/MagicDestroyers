using System;
using MagicDestroyer.Equipment.Armors;
using MagicDestroyer.Equipment.Weapons;

namespace MagicDestroyer.Characters.Spellcasters
{
    class Necromancer
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
                if (value >= 0 && value <= 140)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The value should be >= 0 and <= 140");
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
                throw new ArgumentOutOfRangeException(string.Empty, "The name should be between 4 and 15 letters");
            }
        }
        }
        private LightLeatherVest bodyArmor;
        private Sword weapon;
        public Necromancer() //constructor
        {

        }
         public void ShadowRange()
        {
            throw new NotImplementedException();
        }
         public void VampireTouch()
        {
            throw new NotImplementedException();
        }
         public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}