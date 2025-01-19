namespace HELICOPTER_HELICOPTER
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
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.GAMEEND = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.lblGAMEOVER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.GAMEEND.SuspendLayout();
            this.SuspendLayout();
            // 
            // pillar1
            // 
            this.pillar1.Image = global::HELICOPTER_HELICOPTER.Properties.Resources.pillar;
            this.pillar1.Location = new System.Drawing.Point(571, 0);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(57, 185);
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // pillar2
            // 
            this.pillar2.Image = global::HELICOPTER_HELICOPTER.Properties.Resources.pillar;
            this.pillar2.Location = new System.Drawing.Point(259, 288);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(57, 185);
            this.pillar2.TabIndex = 1;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // player
            // 
            this.player.Image = global::HELICOPTER_HELICOPTER.Properties.Resources.Halicopter;
            this.player.Location = new System.Drawing.Point(90, 105);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 54);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(0, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(102, 29);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Score: 0";
            // 
            // ufo
            // 
            this.ufo.Image = global::HELICOPTER_HELICOPTER.Properties.Resources.alien2;
            this.ufo.Location = new System.Drawing.Point(764, 288);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(68, 72);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 5;
            this.ufo.TabStop = false;
            // 
            // GAMEEND
            // 
            this.GAMEEND.BackColor = System.Drawing.Color.Black;
            this.GAMEEND.Controls.Add(this.label1);
            this.GAMEEND.Controls.Add(this.lbltext);
            this.GAMEEND.Controls.Add(this.lblGAMEOVER);
            this.GAMEEND.Location = new System.Drawing.Point(-5, 0);
            this.GAMEEND.Name = "GAMEEND";
            this.GAMEEND.Size = new System.Drawing.Size(929, 473);
            this.GAMEEND.TabIndex = 6;
            this.GAMEEND.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(283, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press Enter To Restart";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Jokerman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.HotPink;
            this.lbltext.Location = new System.Drawing.Point(279, 196);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(0, 68);
            this.lbltext.TabIndex = 1;
            // 
            // lblGAMEOVER
            // 
            this.lblGAMEOVER.AutoSize = true;
            this.lblGAMEOVER.BackColor = System.Drawing.Color.Black;
            this.lblGAMEOVER.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGAMEOVER.ForeColor = System.Drawing.Color.Red;
            this.lblGAMEOVER.Location = new System.Drawing.Point(167, 79);
            this.lblGAMEOVER.Name = "lblGAMEOVER";
            this.lblGAMEOVER.Size = new System.Drawing.Size(599, 117);
            this.lblGAMEOVER.TabIndex = 0;
            this.lblGAMEOVER.Text = "GAME OVER!!";
            this.lblGAMEOVER.Click += new System.EventHandler(this.lblGAMEOVER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(923, 470);
            this.Controls.Add(this.GAMEEND);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Name = "Form1";
            this.Text = "Helicopter shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.GAMEEND.ResumeLayout(false);
            this.GAMEEND.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.Panel GAMEEND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblGAMEOVER;
    }
}

