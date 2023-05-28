namespace _2D_GAME
{
    partial class Level2
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
            this.components = new System.ComponentModel.Container();
            this.playagain = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_over = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.spaceship2 = new System.Windows.Forms.PictureBox();
            this.meteor2 = new System.Windows.Forms.PictureBox();
            this.meteor = new System.Windows.Forms.PictureBox();
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.picturebox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playagain
            // 
            this.playagain.AutoSize = true;
            this.playagain.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain.ForeColor = System.Drawing.Color.White;
            this.playagain.Location = new System.Drawing.Point(317, 300);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(227, 40);
            this.playagain.TabIndex = 15;
            this.playagain.Text = "Play Again";
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timerEvents);
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_over.Location = new System.Drawing.Point(290, 200);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(279, 57);
            this.lbl_over.TabIndex = 14;
            this.lbl_over.Tag = "";
            this.lbl_over.Text = "Game-Over";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("High Tower Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Red;
            this.lbl_score.Location = new System.Drawing.Point(-8, 1);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(171, 48);
            this.lbl_score.TabIndex = 13;
            this.lbl_score.Text = "Score : 0";
            // 
            // spaceship2
            // 
            this.spaceship2.Image = global::_2D_GAME.Properties.Resources.enemyGreen3;
            this.spaceship2.Location = new System.Drawing.Point(493, 233);
            this.spaceship2.Name = "spaceship2";
            this.spaceship2.Size = new System.Drawing.Size(51, 49);
            this.spaceship2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship2.TabIndex = 19;
            this.spaceship2.TabStop = false;
            this.spaceship2.Tag = "enemy";
            // 
            // meteor2
            // 
            this.meteor2.Image = global::_2D_GAME.Properties.Resources.meteorGrey_big1;
            this.meteor2.Location = new System.Drawing.Point(763, 141);
            this.meteor2.Name = "meteor2";
            this.meteor2.Size = new System.Drawing.Size(53, 46);
            this.meteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meteor2.TabIndex = 18;
            this.meteor2.TabStop = false;
            this.meteor2.Tag = "enemy";
            // 
            // meteor
            // 
            this.meteor.Image = global::_2D_GAME.Properties.Resources.meteorGrey_big2;
            this.meteor.Location = new System.Drawing.Point(345, 81);
            this.meteor.Name = "meteor";
            this.meteor.Size = new System.Drawing.Size(53, 46);
            this.meteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.meteor.TabIndex = 10;
            this.meteor.TabStop = false;
            this.meteor.Tag = "enemy";
            // 
            // spaceship
            // 
            this.spaceship.Image = global::_2D_GAME.Properties.Resources.enemyBlue1;
            this.spaceship.Location = new System.Drawing.Point(29, 52);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(51, 49);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship.TabIndex = 9;
            this.spaceship.TabStop = false;
            this.spaceship.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::_2D_GAME.Properties.Resources.playerShip1_red;
            this.player.Location = new System.Drawing.Point(382, 484);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(61, 48);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 8;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // picturebox2
            // 
            this.picturebox2.Image = global::_2D_GAME.Properties.Resources.Stars_img;
            this.picturebox2.Location = new System.Drawing.Point(-17, -104);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(914, 386);
            this.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox2.TabIndex = 16;
            this.picturebox2.TabStop = false;
            this.picturebox2.Tag = "stars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2D_GAME.Properties.Resources.Stars_img;
            this.pictureBox1.Location = new System.Drawing.Point(-51, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "stars";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.spaceship2);
            this.Controls.Add(this.meteor2);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.meteor);
            this.Controls.Add(this.spaceship);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picturebox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playagain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox meteor;
        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox meteor2;
        private System.Windows.Forms.PictureBox spaceship2;
    }
}