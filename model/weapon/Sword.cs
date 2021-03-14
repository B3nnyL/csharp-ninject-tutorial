using System;
using ninject_learning.model.strength;

namespace ninject_learning.model.weapon
{
    public class Sword : IWeapon
    {
        readonly IStrength _strength;
        public Sword(IStrength strength) {
            _strength = strength;
        }
        
        public void Hit(string target)
        {
            Console.WriteLine("Pierced with sword - {0} - {1}", target, _strength.Point());
        }
    }
}