using System;

namespace Bonus13pg108
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Wizard Class using the default constructor.
            var wizard1 = new Wizard();

            // Create a new isntance of the Wizard Class using the custom constructor.
            Wizard wizard2 = new Wizard("Dudicus", 99, 99, 99, 100);

            Console.WriteLine();
            // This is calling the GameCharacter Method.
            wizard2.PrintStats();
            // this is calling the MagicUsingCharacter Method.
            wizard2.PrintMagicCharacterStats();
            // this is calling the Wizard Method.
            wizard2.PrintWizardStats();

            // This is accessing Properties from GameCharacter, MagicusingCharacter, and Wizard.
            Console.WriteLine($"\nManually calling name {wizard2.Name} {wizard2.Strength} {wizard2.Intelligence} {wizard2.MagicalEnergy} {wizard2.SpellNumber}");
        }
    }
}
