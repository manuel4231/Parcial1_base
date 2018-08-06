using System;

namespace Parcial1_logic.OOP
{
    public class Hero : Actor
    {
        public Hero(float atk, float def)
        {
            baseAtaque = atk;
            baseDefense = def;
        }


        public void Equip(Gear equipamento)
        {
            if (equipamento is Weapon)
                if (baseAtaque * 2 >= (ataque / equipamento.paramMod))
                    ataque = baseAtaque / equipamento.paramMod;
            if (equipamento is Armor)
                if (baseDefense * 2 >= (defensa / equipamento.paramMod))
                    defensa /= equipamento.paramMod;
        }


        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }

        public void GetCurrentAtak()
        {

            Console.WriteLine();
        }
         
        public override void Move(MovementType tipo)
        {
            Console.WriteLine("Input");   
        }
    }
}