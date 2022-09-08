namespace MagicDestroyer.Equipment.Weapons
{
    class Staff
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage need to be positive");
                }
            }
        }
        public Staff()
        {

        }
        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}