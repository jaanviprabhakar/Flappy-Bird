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
        int pipeSpeed = 5; //default pipe speed
        int gravity = 8; //default gravity spped
        int score = 0; //default score set to 0

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; //add gravity to flappybird; += means it will add the speed of gravity to the picture boxes top location so it will move down
            pipeBottom.Left -= pipeSpeed;  // link the bottom pipes left position to the pipe speed integer, so it will move left with each tick
            pipeTop.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign
            scoreText.Text = "Score: " + score.ToString();

            //checking if any pipe left the screen
            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800; // for bottom pipe to re- occur
                score++;
            }

            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 950; // for top pipe to reoccur
                score++;
            }


            //if the bird hits the ground or touches pipes
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(ground.Bounds)|| flappyBird.Top< -40)
            {
                endGame(); //if any condition is met, endgame() fn will run
            }

           if(score > 5)
            {
                pipeSpeed = 8;
            }
            if(score > 15)
            {
                pipeSpeed = 14;
            }

            if(score > 30)
            {
                pipeSpeed = 20;
            }
           
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        { // game key is down event linked to main form
            if (e.KeyCode == Keys.Space)
            {
                if(score <= 5)
                {
                    gravity = -5; // when spacebar is pressed change gravity to -5 for bird to go up
                }
                if(score > 5)
                {
                    gravity = -8;
                }
                
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        { // game key is up event linked to main form
            if(e.KeyCode == Keys.Space)
            {
                if (score <= 5)
                {
                    gravity = 5; //when spacebar is released change it back to 5 for bird to come down
                }

                if (score > 5)
                {
                    gravity = 8;
                }
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "\nGame Over!";
        }
    }
}
