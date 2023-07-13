using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumarableProject
{
    public class Player
    {
        private int run;
        private string name;

        public Player(int run, string name)
        {
            this.run = run;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{run} - {name}";
        }
    }

    public class Team : IEnumerable
    {
        Player[] players;
        public Team()
        {

            players = new Player[3];
            players[0] = new Player(1000, "Sachin");
            players[1] = new Player(1100, "Virat");
            players[2] = new Player(1400, "Dhoni");

        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
