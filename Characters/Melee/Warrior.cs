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