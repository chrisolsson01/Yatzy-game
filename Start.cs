using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2
{
    public class Start
    {
        public Hand _hand = new Hand();
        public int UserInput;
        public bool GameStarted = true;
        public int tries = 3;

        public void Game(){
            Console.Clear();
            System.Console.WriteLine("Välkommen");
            System.Console.WriteLine("1. Rulla alla tärningar");
            System.Console.WriteLine("2. Avsluta spelet");
            int x = int.Parse(Console.ReadLine());
            if(x == 1){
                Round();
            }
        }

        public void Round(){
            while(GameStarted){
            
            System.Console.WriteLine("Alternativ\n1.Rulla Alla tärningar\n2.Avsluta\n3.Spara");
            if (!int.TryParse(Console.ReadLine(), out UserInput))
                {
                    Console.WriteLine("Försök igen");
                } else
                {
                    switch (UserInput)
                    {
                        case 1:
                            _hand.ReRollAll();
                            tries--;
                            if(tries == 0){
                                break;
                            }
                            break;
                      
                        case 2:
                            GameStarted = false;
                            Console.WriteLine("Avslutar");
                            break;

                        case 3:
                            tries--;
                            _hand.KeepDices(AskSave());
                            if(tries == 0){
                                break;
                            }
                            break;


                        default:
                            break;
                    }
                }
            }
        }

        public int[] AskSave(){
            System.Console.WriteLine("Vilka tärningar vill du spara");
            string _userInput = Console.ReadLine();
            string[] ChosenDices = _userInput.Split(',');
            int[] toReroll = new int[ChosenDices.Length];
            for(int i = 0;i < ChosenDices.Length; i++){
                toReroll[i] = int.Parse(ChosenDices[i]);
            }

            foreach(int value in toReroll){
                System.Console.WriteLine(value);
            }
            return toReroll;
        }
    }
}