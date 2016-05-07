using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        private float sum = 0;
        Label firstClicked = null;
        Label secondClicked = null;
        byte time = 90;


        public MemoryGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        Random random = new Random();
        List<string> icons = new List<string>() 
    { 
        "?", "?", "N", "N", ",", ",", "j", "j",
        "b", "b", "a", "a", "w", "w", "z", "z"
    };
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                     iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Red;
                    return;
                }

               
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Red;
                CheckForWinner();
                CalculateTotal();
              
                if (firstClicked.Text == secondClicked.Text)
                {
                    
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
               
               
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            
            SoundPlayer sound = new SoundPlayer(Properties.Resources.applause8);
            sound.Play();
            MessageBox.Show(string.Format("Освоивте: {0} поени", sum), "Честитки");
            
            
            
            Close();
        }

        private void CalculateTotal() {
            float pointsGuess = 20;
            float pointsWrong = - 5;
            
            if (firstClicked.Text == secondClicked.Text)
            {
                sum += pointsGuess;
            }
            if (firstClicked.Text != secondClicked.Text)
            {
                sum += pointsWrong;
            }
            tbPoints.Text = string.Format("{0:0.00}", sum);
            
            
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time -= 1;
            label18.Text = "Time = " + time;
            if (time == 0)
            {
                SoundPlayer sound1 = new SoundPlayer(Properties.Resources.game_over);
                sound1.Play();
                if (MessageBox.Show("Дали сакате нова игра?", "Нова игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sound1.Stop();
                    MemoryGame newform = new MemoryGame();
                    this.Hide();
                    newform.ShowDialog();
                    
                }
                else
                    Application.Exit();
                label18.Text = "Game finished";
               
                this.Enabled = false;
            }
        }
    }

    }
    