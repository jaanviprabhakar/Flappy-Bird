using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        //variables
        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; //add gravity
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            if(pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800; // for bottom pipe to re- occur
            }

            if(pipeTop.Left < -80)
            {
                pipeTop.Left = 950; // for top pipe to reoccur
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10; // when spacebar is pressed change gravity to -5 for bird to go up
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 10; //when spacebar is released change it back to 5 for bird to come down
            }

        }
    }
}
