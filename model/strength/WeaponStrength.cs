using System;

namespace ninject_learning.model.strength
{
    public class WeaponStrength : IStrength
    {

        int _point = 0;
        public int Point()
        {
            return _point++;
        }
    }
}