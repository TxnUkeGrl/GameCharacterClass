using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13pg108
{
    public class Wizard : MagicUsingCharacter
    {
        // This is a property. Look at Game Characters Name property to see what this is doing
        // in the background.
        public int SpellNumber { get; set; }

        // Default constructor. Will exist if no other constructor exists, otherwise must
        // be specified.
        public Wizard()
        {

        }

        // Custom constructor. Set values that get pass in via here.
        public Wizard(string name, int str, int intelligence, int energy, int spellnumber)
        {
            Name = name;
            Strength = str;
            Intelligence = intelligence;
            MagicalEnergy = energy;
            SpellNumber = spellnumber;
        }

        // Example method of doing something but not returning anything.
        public void PrintWizardStats()
        {
            Console.WriteLine($" SpellNumber: {SpellNumber}.");
        }
    }
}
