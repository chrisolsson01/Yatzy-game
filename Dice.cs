using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2
{
    public class Dice
    {
        public static Random rnd = new Random();

        public int NumDices {get;private set;}

        public Dice(){
            NumDices = rnd.Next(1, 7);
        }

        public void Reroll(){
            NumDices = rnd.Next(1, 7);
        }
    }
}