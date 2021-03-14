using ninject_learning.model.weapon;

namespace ninject_learning.model.sarumai
{
    public class Ninja : IWarrior
    {
        readonly IWeapon _weapon;
        public Ninja(IWeapon weapon)
        {
            this._weapon = weapon;
        }
        public void Attack(string target)
        {
            this._weapon.Hit(target);

        }

        public void Equip()
        {
            throw new System.NotImplementedException();
        }
    }
}