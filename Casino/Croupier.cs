using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Croupier : Player
    {
        public int Table { get; set; }

        public Croupier(string name, double money, int table) : base(name, money)
        {
            Table = table;
        }

        public void Win(Player player, double bid)
        {
            base.Win(bid);
            player.Loose(bid);
        }

        public void Loose(Player player, double bid)
        {
            base.Loose(bid);
            player.Win(bid);
        }
    }
}
