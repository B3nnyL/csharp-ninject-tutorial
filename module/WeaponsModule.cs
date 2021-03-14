using Ninject;
using Ninject.Modules;
using ninject_learning.model.sarumai;
using ninject_learning.model.strength;
using ninject_learning.model.weapon;

namespace ninject_learning.module
{
    public class WeaponsModule: NinjectModule
    {
        public override void Load()
        {
            //Bind<IWeapon>().To<Sword>();

            // Result with singleton IStrength
            // Chopped with Shuriken - gai + 0
            // Chopped with Shuriken - hey + 1
            // Pierced with sword - silence - 2

            //Inject iStrength to weaponStrength in the global container
            Bind<IStrength>().To<WeaponStrength>().InSingletonScope();

            //Inject IWeapon as Shuriken for Samurai, constructor with IStrength Singlton
            Bind<IWeapon>()
                .ToMethod(ctx => new Shuriken(ctx.Kernel.Get<IStrength>()))
                .WhenInjectedInto<Samurai>()
                .InSingletonScope();

            //Inject IWeapon as Shuriken for Ninja, constructor with IStrength Singlton
            Bind<IWeapon>()
                .ToMethod(ctx => new Sword(ctx.Kernel.Get<IStrength>()))
                .WhenInjectedInto<Ninja>()
                .InSingletonScope();

            // Result with transient IStrength
            // Chopped with Shuriken - gai + 0
            // Chopped with Shuriken - hey + 1
            // Pierced with sword - silence - 0
            // Bind<IStrength>().To<WeaponStrength>();
            // Bind<IWeapon>()
            //     .ToMethod(ctx => new Shuriken(ctx.Kernel.Get<IStrength>()))
            //     .WhenInjectedInto<Samurai>()
            //     .InSingletonScope();

            // Bind<IWeapon>()
            //     .ToMethod(ctx => new Sword(ctx.Kernel.Get<IStrength>()))
            //     .WhenInjectedInto<Ninja>()
            //     .InSingletonScope();
        }
        
    }
}