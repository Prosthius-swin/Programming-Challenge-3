using System;
using System.Collections.Generic;

namespace DiceTask
{
    public abstract class Game
    {
        public static List<Die> dice = new List<Die>();

        public abstract int RollAllDice();
        public static void AddDie(int sides)
        {
            dice.Add(new Die (sides));
        }
    }
}
