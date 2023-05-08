using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SimpleGame
{
    public partial class Form1 : Form
    {
        private int CarSpeed = 0;
        private int Collected_Coins = 0;
        private int Time = 40;
        public void MoveLine()
        {
            if (Line1.Top > 500) Line1.Top = 0;
            else Line1.Top += CarSpeed;
            if (Line2.Top > 500) Line2.Top = 0;
            else Line2.Top += CarSpeed;
            if (Line3.Top > 500) Line3.Top = 0;
            else Line3.Top += CarSpeed;
            if (Line4.Top > 500) Line4.Top = 0;
            else Line4.Top += CarSpeed;
        }
        public void MoveCoin()
        {
            Random R = new Random();
            if (Coin1.Top > 500)
            {
                Coin1.Left = R.Next(11, 100);
                Coin1.Top = 0;
            }
            else Coin1.Top += CarSpeed;
            if (Coin2.Top > 500)
            {
                Coin2.Left = R.Next(100, 190);
                Coin2.Top = 0;
            }
            else Coin2.Top += CarSpeed;
            if (Coin3.Top > 500)
            {
                Coin3.Left = R.Next(200, 290);
                Coin3.Top = 0;
            }
            else Coin3.Top += CarSpeed;
            if (Coin4.Top > 500)
            {
                Coin4.Left = R.Next(300, 370);
                Coin4.Top = 0;
            }
            else Coin4.Top += CarSpeed;
        }
       public void MoveEnemy()
        {
            Random R = new Random();
            if (Enemy1.Top > 500)
            {
                Enemy1.Left = R.Next(11, 100);
                Enemy1.Top = 0;
            }
            else Enemy1.Top += CarSpeed;
            if (Enemy2.Top > 500)
            {
                Enemy2.Left = R.Next(100, 190);
                Enemy2.Top = 0;
            }
            else Enemy2.Top += CarSpeed;
            if (Enemy3.Top > 500)
            {
                Enemy3.Left = R.Next(200, 290);
                Enemy3.Top = 0;
            }
            else Enemy3.Top += CarSpeed;
            if (Enemy4.Top > 500)
            {
                Enemy4.Left = R.Next(300, 370);
                Enemy4.Top = 0;
            }
            else Enemy4.Top += CarSpeed;
        }
        public void GameOver()
        {
            if (MyCar.Bounds.IntersectsWith(Enemy1.Bounds) ||
               MyCar.Bounds.IntersectsWith(Enemy2.Bounds) ||
               MyCar.Bounds.IntersectsWith(Enemy3.Bounds) ||
               MyCar.Bounds.IntersectsWith(Enemy4.Bounds))
            {
                Finish.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }
        public void Points()
        {
            Random R = new Random();
            if (MyCar.Bounds.IntersectsWith(Coin1.Bounds))
            {
                Collected_Coins++;
                Coins.Text="Coins "+Collected_Coins;
                Coin1.Left = R.Next(11, 100);
                Coin1.Top = 0;
            }
            if (MyCar.Bounds.IntersectsWith(Coin2.Bounds))
            {
                Collected_Coins++;
                Coins.Text = "Coins " + Collected_Coins;
                Coin2.Left = R.Next(100, 190);
                Coin2.Top = 0;
            }
            if (MyCar.Bounds.IntersectsWith(Coin3.Bounds))
            {
                Collected_Coins++;
                Coins.Text = "Coins " + Collected_Coins;
                Coin3.Left = R.Next(200, 290);
                Coin3.Top = 0;
            }
            if (MyCar.Bounds.IntersectsWith(Coin4.Bounds))
            {
                Collected_Coins++;
                Coins.Text = "Coins " + Collected_Coins;
                Coin4.Left = R.Next(300, 370);
                Coin4.Top = 0;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine();
            MoveEnemy();
            GameOver();
            MoveCoin();
            Points();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up && CarSpeed<20) CarSpeed++;
            if(e.KeyCode==Keys.Down && CarSpeed>0) CarSpeed--;
            if (e.KeyCode == Keys.Left && MyCar.Left>11) MyCar.Left -= 5;
            if (e.KeyCode == Keys.Right && MyCar.Right<370) MyCar.Left += 5;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
            {
                Time--;
                Timer.Text = "Time: " + Time;
            }
            else
            {
                Finish.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        private void Enemy1_Click(object sender, EventArgs e)
        {

        }
    }
}
