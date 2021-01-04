using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamen_skarje_papir
{
    public partial class Form1 : Form
    {

        Game igra = new Game();
        public Form1()
        {
            InitializeComponent();
        }

        public void update()
        {
            label4.Text = Convert.ToString(igra.player1Score);
            label3.Text = Convert.ToString(igra.player2Score);
            label7.Text = Convert.ToString(Game.player1Highscore);
            label8.Text = Convert.ToString(Game.player2Highscore);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            igra.Play();
            
            if (igra.player1State == 0)
            {
                kamen1.Visible = true;
                skarje1.Visible = false;
                papir1.Visible = false;
            }
            if (igra.player1State == 1)
            {
                kamen1.Visible = false;
                skarje1.Visible = true;
                papir1.Visible = false;

            }
            if (igra.player1State == 2)
            {
                kamen1.Visible = false;
                skarje1.Visible = false;
                papir1.Visible = true;
            }
            //player2
            if(igra.player2State == 0)
            {
                kamen2.Visible = true;
                skarje2.Visible = false;
                papir2.Visible = false;
            }
            if(igra.player2State == 1)
            {
                kamen2.Visible = false;
                skarje2.Visible = true;
                papir2.Visible = false;
            }
            if (igra.player2State == 2)
            {
                kamen2.Visible = false;
                skarje2.Visible = false;
                papir2.Visible = true;
            }


            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            igra.Reset();
            update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kamen1.Visible = false;
            skarje1.Visible = false;
            papir1.Visible = false;
            kamen2.Visible = false;
            skarje2.Visible = false;
            papir2.Visible = false;
        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
