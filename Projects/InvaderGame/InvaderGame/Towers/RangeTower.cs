using System;
namespace InvaderGame
{
    class RangeTower : Tower
    {
        protected override int Range { get; } = 2;

        public RangeTower(MapLocation mapLocation) : base(mapLocation)
        {
        }
    }
}
