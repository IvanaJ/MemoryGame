namespace MemoryGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHow = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(238, 98);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(135, 35);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHow
            // 
            this.btnHow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHow.Location = new System.Drawing.Point(238, 144);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(135, 35);
            this.btnHow.TabIndex = 1;
            this.btnHow.Text = "HOW TO PLAY";
            this.btnHow.UseVisualStyleBackColor = false;
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.Location = new System.Drawing.Point(238, 190);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(135, 35);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "BEST SCORES";
            this.btnScores.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(238, 236);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 35);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "QUIT GAME";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackgroundImage = global::MemoryGame.Properties.Resources._1461957383_device_volume_loudspeaker_speaker_up_glyph;
            this.btnSound.Location = new System.Drawing.Point(491, 11);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(36, 35);
            this.btnSound.TabIndex = 4;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::MemoryGame.Properties.Resources._1461957451_device_volume_loudspeaker_speaker_mute_glyph;
            this.btnPause.Location = new System.Drawing.Point(533, 11);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(36, 35);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 390);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnHow);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnPause;
    }
}

