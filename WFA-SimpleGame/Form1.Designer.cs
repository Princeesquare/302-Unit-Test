namespace WFA_SimpleGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Line1 = new System.Windows.Forms.PictureBox();
            this.Line2 = new System.Windows.Forms.PictureBox();
            this.Line3 = new System.Windows.Forms.PictureBox();
            this.Line4 = new System.Windows.Forms.PictureBox();
            this.RightLine = new System.Windows.Forms.PictureBox();
            this.LeftLine = new System.Windows.Forms.PictureBox();
            this.MyCar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.Enemy4 = new System.Windows.Forms.PictureBox();
            this.Finish = new System.Windows.Forms.Label();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.Coins = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.Location = new System.Drawing.Point(189, 1);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(10, 86);
            this.Line1.TabIndex = 0;
            this.Line1.TabStop = false;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.White;
            this.Line2.Location = new System.Drawing.Point(189, 128);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(10, 84);
            this.Line2.TabIndex = 1;
            this.Line2.TabStop = false;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.White;
            this.Line3.Location = new System.Drawing.Point(189, 257);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(10, 78);
            this.Line3.TabIndex = 2;
            this.Line3.TabStop = false;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.White;
            this.Line4.Location = new System.Drawing.Point(189, 372);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(10, 77);
            this.Line4.TabIndex = 3;
            this.Line4.TabStop = false;
            // 
            // RightLine
            // 
            this.RightLine.BackColor = System.Drawing.Color.White;
            this.RightLine.Location = new System.Drawing.Point(374, 1);
            this.RightLine.Name = "RightLine";
            this.RightLine.Size = new System.Drawing.Size(10, 459);
            this.RightLine.TabIndex = 4;
            this.RightLine.TabStop = false;
            // 
            // LeftLine
            // 
            this.LeftLine.BackColor = System.Drawing.Color.White;
            this.LeftLine.Location = new System.Drawing.Point(-1, 1);
            this.LeftLine.Name = "LeftLine";
            this.LeftLine.Size = new System.Drawing.Size(10, 459);
            this.LeftLine.TabIndex = 5;
            this.LeftLine.TabStop = false;
            // 
            // MyCar
            // 
            this.MyCar.Image = ((System.Drawing.Image)(resources.GetObject("MyCar.Image")));
            this.MyCar.Location = new System.Drawing.Point(76, 351);
            this.MyCar.Name = "MyCar";
            this.MyCar.Size = new System.Drawing.Size(27, 54);
            this.MyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyCar.TabIndex = 6;
            this.MyCar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Enemy1
            // 
            this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
            this.Enemy1.Location = new System.Drawing.Point(41, 37);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(25, 50);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 7;
            this.Enemy1.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
            this.Enemy2.Location = new System.Drawing.Point(132, 98);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(25, 50);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 8;
            this.Enemy2.TabStop = false;
            // 
            // Enemy3
            // 
            this.Enemy3.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3.Image")));
            this.Enemy3.Location = new System.Drawing.Point(239, 68);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(25, 50);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3.TabIndex = 9;
            this.Enemy3.TabStop = false;
            // 
            // Enemy4
            // 
            this.Enemy4.Image = ((System.Drawing.Image)(resources.GetObject("Enemy4.Image")));
            this.Enemy4.Location = new System.Drawing.Point(321, 50);
            this.Enemy4.Name = "Enemy4";
            this.Enemy4.Size = new System.Drawing.Size(25, 50);
            this.Enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy4.TabIndex = 10;
            this.Enemy4.TabStop = false;
            // 
            // Finish
            // 
            this.Finish.AutoSize = true;
            this.Finish.BackColor = System.Drawing.Color.Gold;
            this.Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Finish.ForeColor = System.Drawing.Color.Red;
            this.Finish.Location = new System.Drawing.Point(92, 170);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(219, 42);
            this.Finish.TabIndex = 11;
            this.Finish.Text = "Game Over";
            this.Finish.Visible = false;
            // 
            // Coin1
            // 
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(41, 98);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(27, 26);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 12;
            this.Coin1.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(119, 37);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(27, 26);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 13;
            this.Coin2.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.Location = new System.Drawing.Point(224, 36);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(27, 26);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 14;
            this.Coin3.TabStop = false;
            // 
            // Coin4
            // 
            this.Coin4.Image = ((System.Drawing.Image)(resources.GetObject("Coin4.Image")));
            this.Coin4.Location = new System.Drawing.Point(284, 36);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(27, 26);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin4.TabIndex = 15;
            this.Coin4.TabStop = false;
            // 
            // Coins
            // 
            this.Coins.AutoSize = true;
            this.Coins.BackColor = System.Drawing.Color.Gold;
            this.Coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Coins.ForeColor = System.Drawing.Color.Red;
            this.Coins.Location = new System.Drawing.Point(12, 1);
            this.Coins.Name = "Coins";
            this.Coins.Size = new System.Drawing.Size(79, 20);
            this.Coins.TabIndex = 16;
            this.Coins.Text = "Coins:    ";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.Gold;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Timer.ForeColor = System.Drawing.Color.Red;
            this.Timer.Location = new System.Drawing.Point(300, 1);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(72, 20);
            this.Timer.TabIndex = 17;
            this.Timer.Text = "Time:    ";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Coins);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Enemy4);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.MyCar);
            this.Controls.Add(this.LeftLine);
            this.Controls.Add(this.RightLine);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Line1;
        private System.Windows.Forms.PictureBox Line2;
        private System.Windows.Forms.PictureBox Line3;
        private System.Windows.Forms.PictureBox Line4;
        private System.Windows.Forms.PictureBox RightLine;
        private System.Windows.Forms.PictureBox LeftLine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Finish;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin4;
        private System.Windows.Forms.Label Coins;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.PictureBox MyCar;
        public System.Windows.Forms.PictureBox Enemy1;
        public System.Windows.Forms.PictureBox Enemy2;
        public System.Windows.Forms.PictureBox Enemy3;
        public System.Windows.Forms.PictureBox Enemy4;
    }
}

