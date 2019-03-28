using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class BoardGame
    {
        public Player player;
        public Die die;

        public BoardGame(string playerName)
        {
            player = new Player(new int[1,1] ,playerName);
            die = new Die();
        }
    }
}
