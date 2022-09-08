namespace MagicDestroyer.Equipment.Armors
{
    class LightLeatherVest
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get => armorPoints;
            set
            {
                if (value >= 0)
                {
                    value = armorPoints;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "armorPoints should be positive numbers");
                }
            }
        }
        public LightLeatherVest()
        {

        }
    }
}