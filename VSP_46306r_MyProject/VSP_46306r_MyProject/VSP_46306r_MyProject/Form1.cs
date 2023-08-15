using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_46306r_MyProject
{
    public partial class Form1 : Form
    {

        int score = 0;   
        int highscore = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            generateLvl();
            progressBar1.Value = 100;
            healthDecrease.Enabled = true;
            btnStart.Visible = false;
            
        }
        private void generateLvl()
        {
            Random rnd = new Random();
            int[] numsArray = { 1, 2, 3, 4 };

            int targetcolor = rnd.Next(1, 4);
           

            for (int i = 0; i < numsArray.Length; i++)
            {
                int randomIndex = rnd.Next(numsArray.Length);
                int temp = numsArray[randomIndex];
                numsArray[randomIndex] = numsArray[i];
                numsArray[i] = temp;


                switch (numsArray[i])
                {
                    case 1: button1.BackColor = Color.Purple;
                        button2.BackColor = Color.Red;
                        button3.BackColor = Color.Green;
                        button4.BackColor = Color.Blue;
                        break;

                    case 2: button1.BackColor = Color.Red;
                        button2.BackColor = Color.Blue;
                        button3.BackColor = Color.Purple;
                        button4.BackColor = Color.Green;
                        break;

                    case 3: button1.BackColor = Color.Blue;
                        button2.BackColor = Color.Green;
                        button3.BackColor = Color.Red;
                        button4.BackColor = Color.Purple;
                        break;

                    case 4: button1.BackColor = Color.Green;
                        button2.BackColor = Color.Purple;
                        button3.BackColor = Color.Blue;
                        button4.BackColor = Color.Red;
                        break;
                }
            }
            
            switch(targetcolor)
            {
                case 1: targetColorTb.Text = "Purple";
                    targetColorTb.ForeColor = Color.Purple;
                    break;
                case 2: targetColorTb.Text = "Red";
                    targetColorTb.ForeColor = Color.Red;
                    break;
                case 3: targetColorTb.Text = "Green";
                    targetColorTb.ForeColor = Color.Green;
                    break;
                case 4: targetColorTb.Text = "Blue";
                    targetColorTb.ForeColor = Color.Blue;
                    break;
            }

            btnRestart.Visible = false;
        }

        private void checker(string color)

        {
            if (color == "Color ["+  targetColorTb.Text + "]")
            {
                generateLvl();
                score++;
                scoreLb.Text = score.ToString();
                Random rnd = new Random();
                if (score > 15)
                { 
                    healthDecrease.Interval = 45;
                    int newColor = rnd.Next(1, 4);

                    switch(newColor)
                    {
                        case 1: targetColorTb.ForeColor = Color.Red;
                            break;
                        case 2: targetColorTb.ForeColor = Color.Blue;
                            break;
                        case 3: targetColorTb.ForeColor = Color.Purple;
                            break;
                        case 4: targetColorTb.ForeColor = Color.Green;
                            break;
                    }
                }
                //exception if the hp > 100
                try
                {
                    progressBar1.Value += 15;
                }
                catch
                {
                    progressBar1.Value = 100;
                }
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checker(button1.BackColor.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checker(button2.BackColor.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checker(button3.BackColor.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checker(button4.BackColor.ToString());
        }

        private void healthDecrease_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 0)
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                targetColorTb.Text = "Game Over";
                targetColorTb.ForeColor = Color.Black;  
                btnRestart.Visible = true;
                if (score > highscore)
                {
                    highscore = score;
                    highScoreLb.Text = highscore.ToString();
                }
                
                score = 0;
                scoreLb.Text = score.ToString();
            }
            //exception if the progressbar value < 0;
            try
            {
                progressBar1.Value -= 1;
            }
            catch
            {
                progressBar1.Value = 0;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            generateLvl();
            progressBar1.Value = 100;
        }
        // selection problem
        private void targetColorTb_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Focus();
        }
    }
}
