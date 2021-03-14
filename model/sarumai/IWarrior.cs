using ninject_learning.model.weapon;

namespace ninject_learning.model.sarumai
{
    public interface IWarrior
    {
        public void Attack(string target);

        public void Equip();
    }
}