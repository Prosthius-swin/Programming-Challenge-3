using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DiceTask
{
    public class Die
    {
        public static int sides { get; set; }
        public Die(int pSides)
        {
            sides = pSides;
        }
        public Die()
        {
            sides = 6;
        }
        public int Roll()
        {
            Random rnd = new Random();
            int diceRolls = rnd.Next(1, sides + 1);
            return diceRolls; 
        }
    }
}
