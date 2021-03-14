using System;
using Ninject;
using ninject_learning.model.sarumai;
using ninject_learning.model.weapon;
using ninject_learning.module;

namespace ninject_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // traditional binding
            // var warriorA = new Sarumai(new Sword());
            // var warriorB = new Sarumai(new Shuriken());
            // warriorA.Attack("the invader");
            // warriorB.Attack("the invader");

            IKernel kernel = new StandardKernel(new WeaponsModule());
            Samurai warriorA = kernel.Get<Samurai>();
            warriorA.Attack("gai");

            Samurai warriorB = kernel.Get<Samurai>();
            warriorB.Attack("hey");

            Ninja warriorC = kernel.Get<Ninja>();
            warriorC.Attack("silence");
        }
    }
}
