namespace MagicDestroyer.Equipment.Weapons
{
    class Sword
    {
        private int damage;

        public Sword()
        {

        }
        public int Damage { 
            get
            {
                return damage;
            } 
            set
            {
                if(value >= 0)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage need to be positive");
                }
            }
             }
        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}