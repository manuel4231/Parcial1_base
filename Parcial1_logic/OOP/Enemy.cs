using System;

namespace Parcial1_logic.OOP
{
    public class Enemy : Actor
    {
        public override void Move(MovementType tipo)
        {
            Console.Write("Controlado por una IA");
        }
    }
}