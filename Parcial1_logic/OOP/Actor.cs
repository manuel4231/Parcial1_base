namespace Parcial1_logic.OOP
{
    public abstract class Actor : ICharacter
    {
        protected float baseAtaque;
        protected float baseDefense;
        protected float ataque;
        protected float defensa;
        public abstract void Move(MovementType tipo);


        void Atacar(Actor target)
        {

        }

    }
}