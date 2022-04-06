using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Kostas = new Wizard("Kostas");
            Wizard Brandon = new Wizard("Brandon");
            Ninja Lucas = new Ninja("Lucas");
            Samurai Sebastian = new Samurai("Samurai");

            Sebastian.SamuraiAttack(Brandon);
            Kostas.Heal(Brandon);
            Sebastian.Meditate();
            Lucas.Steal(Kostas);
        }
    }
}
