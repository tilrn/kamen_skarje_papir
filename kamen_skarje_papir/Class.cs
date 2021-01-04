using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
namespace kamen_skarje_papir
{
     public class HelperClass
    {

        public static Random rand = new Random();
        public static int GetState()
        {
            int random = rand.Next(0, 3);
            return random;
        }
    
    }
    public class Game
    {
        public int player1Score { get; set; }
        public int player2Score { get; set; }
        public int player1State { get; set; }
        public int player2State { get; set; }
        public static int player1Highscore;
        public static int player2Highscore;

        //Metode
        public Game()
        {
            player1Score = 0;
            player1Highscore = 0;
            player2Score = 0;
            player2Highscore = 0;
        }
        public int Play() 
        {
            int kamen = 0;
            int skarje = 1;
            int papir = 2;
            player1State = HelperClass.GetState();
            player2State = HelperClass.GetState();
            if (player1State == player2State)
            {

            }
            else
            {
                if (player1State == kamen && player2State == skarje || player1State == skarje && player2State == papir || player1State == papir && player2State == kamen)
                {
                    player1Score = player1Score + 1;
                    //MessageBox.Show("zmagal je prvi"+ player1State +"pa se player 2 state: " + player2State);
                    if (player1Score > player1Highscore)
                    {
                        player1Highscore = player1Score;
                    }
                    return 1;
                    
                }

                if (player2State == kamen && player1State == skarje || player2State == skarje && player1State == papir || player2State == papir && player1State == kamen)
                {
                    player2Score = player2Score + 1;
                    //MessageBox.Show("zmagal je drugi"+ player2State + "pa se prvi: "+ player1State);
                    if (player2Score > player2Highscore)
                    {
                        player2Highscore = player2Score;
                    }
                    return 2;
                }
            }
            
           
                return 0;
        }
        public void Reset()
        {
            player1Score = 0;
            player2Score = 0;            
        }

    }
}
