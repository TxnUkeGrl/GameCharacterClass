using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13pg108
{
    public class GameCharacter
    {
        // public string Name { get; set; }
        private string _name;
        public string Name { get
            {
                return _name;
            }
            set 
            {
                _name = value;
            } 
        }

        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public void PrintStats()
        {
            Console.Write($"HI! I'm {Name}! My stats are: Str {Strength} Int {Intelligence}");
        }
    }
}
