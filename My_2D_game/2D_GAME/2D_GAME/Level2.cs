using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_GAME
{
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
            lbl_over.Hide();
            playagain.Hide();
        }

        bool right, left, space;
        int score = 0;

        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.explosion;
                                score++;
                                lbl_score.Text = "Score : " + score;
                            }
                            if (score == 15)
                            {
                                Congrats newForm = new Congrats();
                                this.Hide();
                                timer1.Stop();
                                newForm.Show();
                            }
                        }
                    }
                }
            }
        }
        void Game_Over()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        lbl_over.Show();
                        lbl_over.BringToFront();
                        playagain.Show();
                        playagain.BringToFront();
                    }
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        timer1.Stop();
                        lbl_over.Show();
                        lbl_over.BringToFront();
                        playagain.Show();
                        playagain.BringToFront();
                    }
                }
            }
        }
        void Star()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 10;
                    if (j.Top > 400)
                    {
                        j.Top = 0;
                    }
                }
            }
        }
        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Image = Properties.Resources.bullet_img;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Size = new Size(10, 30);
            bullet.Left = player.Left + 15;
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        private void playagain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
        void Bullet_Movement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }
        void Enemy_Movement()
        {
            Random rnd = new Random();
            int x, y, z, j;
            if (spaceship.Top >= 700)
            {
                x = rnd.Next(0, 300);
                spaceship.Location = new Point(x, 0);
            }
            if (meteor.Top >= 600)
            {
                y = rnd.Next(0, 400);
                meteor.Location = new Point(y, 0);
            }
            if (meteor2.Top >= 600)
            {
                z = rnd.Next(0, 500);
                meteor.Location = new Point(z, 0);
            }
            if (spaceship2.Top >= 400)
            {
                j = rnd.Next(0, 600);
                meteor.Location = new Point(j, 0);
            }
            else
            {
                spaceship.Top += 5;
                meteor.Top += 4;
                meteor2.Top += 5;
                spaceship2.Top += 4;
            }
        }
        void Arrow_key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 540)
                {
                    player.Left += 30;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 30;
                }
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }
        private void timerEvents(object sender, EventArgs e)
        {
            Arrow_key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Star();
            Game_Result();
            Game_Over();
        }
       
    }
}
