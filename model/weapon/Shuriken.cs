using System;
using ninject_learning.model.strength;

namespace ninject_learning.model.weapon
{
    public class Shuriken : IWeapon
    {

        readonly IStrength _strength;
        public Shuriken(IStrength strength)
        {
            _strength = strength;
        }
        public void Hit(string target)
        {
            Console.WriteLine("Chopped with Shuriken - {0} + {1}", target, _strength.Point());
        }
    }
}