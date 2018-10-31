using System;
namespace InvaderGame
{
     class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
         if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor); // calls the base classes method
            }
            else
            {
                Console.WriteLine("Shot at a shileded invader but the shot was blocked.");
            }
        }
    }
}
