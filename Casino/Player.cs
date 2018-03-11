using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Player
    {
        public string Name { get; set; }
        public double Money { get; set; }
        
        public Player(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public int RollDice()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return  r.Next(1, 6);

        }

        public void Loose(double bid)
        {
            Money -= bid;
        }

        public void Win(double bid)
        {
            Money += bid;
        }
    }
}
