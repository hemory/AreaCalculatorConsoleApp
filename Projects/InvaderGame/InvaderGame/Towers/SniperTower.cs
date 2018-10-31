using System;
namespace InvaderGame
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 1.25;

        public SniperTower(MapLocation mapLocation) : base(mapLocation)
        {
        }
    }
}
