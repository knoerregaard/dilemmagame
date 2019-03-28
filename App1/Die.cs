using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    static class Die
    {
        static public int eyes { get; set; }

        static public int ThrowDice()
        {
            Random rnd = new Random();
            return rnd.Next(1,7);
        }
    }
}
