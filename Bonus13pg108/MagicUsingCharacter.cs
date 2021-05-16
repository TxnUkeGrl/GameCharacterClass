using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13pg108
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public void PrintMagicCharacterStats()
        {
            Console.Write($" ME: {MagicalEnergy}");
        }
    }
}
