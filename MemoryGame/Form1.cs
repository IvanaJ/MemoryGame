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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlaySound();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           MemoryGame newform = new MemoryGame();
            this.Hide();
            newform.ShowDialog();
        }
        private bool btnWasClicked = false;
        private void PlaySound()
        {
            SoundPlayer game = new SoundPlayer(Properties.Resources.game);
            
            if (btnWasClicked)
            {
                game.Stop();
            }
            else
                game.PlayLooping();

        }

       
        private void btnSound_Click(object sender, EventArgs e)
        {
            btnWasClicked = false;
            PlaySound();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnWasClicked = true;
            PlaySound();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            HowToPlay rules = new HowToPlay();
            this.Hide();
            rules.ShowDialog();
        }
    }
}
