namespace Parcial1_logic.OOP
{
    public class Hero
    {
        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }
    }
}