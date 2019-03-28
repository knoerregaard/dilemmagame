using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Player
    {

        public int position { get; set; }
        public int[,] Path { get; set; }
        public Player(int[,] path)
        {
            //On initialization, the position is 0
            this.position = 0;
            this.Path = path;
        }

        public void MovePlayer(int eyes)
        {
            //From postition in array

            //add the eyes to position. Updated position. Will be to To.
            this.position += eyes;
        }



    }
}
