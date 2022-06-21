using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceTask
{
    public class ClGame:Game
    {
        public string name { get; set; }
        public List<int> results = new List<int>();

        public double GetAverage()
        {
            int total = GetTotal();
            double average = total / results.Count;
            return average;
        }
        public int GetTotal()
        {
            int total = results.Sum();
            return total;
        }
        public override int RollAllDice()
        {
            foreach(Die i in dice)
            {
                results.Add(i.Roll());
            }
            return 1;
        }
    }
}
