using ninject_learning.model.weapon;

namespace ninject_learning.model.sarumai
{
    public class Samurai : IWarrior
    {
        readonly IWeapon _weapon;
        public Samurai(IWeapon weapon)
        {
            this._weapon = weapon;
        }

        public void Attack(string target) => this._weapon.Hit(target);

        public void Equip()
        {
            this._weapon.Hit("just equip");
        }
    }
}