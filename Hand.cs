using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2
{
    public class Hand 
    {
        public bool FirstRound = true;

        public int NumDices{get;set;}

        public Dice[] Dices = {
            new Dice(),
            new Dice(),
            new Dice(),
            new Dice(),
            new Dice()
        };

        public void KeepDices(int[] toReroll) {
            for(int i = 0; i < Dices.Length; i++){
                bool num = false;

                foreach(int roll in toReroll){
                    if(Dices[i].NumDices == roll){
                        num = true;
                    }
                }

                if(num){
                    continue;
                }else {Dices[i].Reroll();}
            }
            ShowDices();
        }

        public void ShowDices(){
            foreach(Dice dice in Dices){
                System.Console.WriteLine("[{0}] ", dice.NumDices);
            }
        }

        public void ReRollAll(){
            foreach(Dice dice in Dices){
                dice.Reroll();
            }

            ShowDices();
        }
    }

}