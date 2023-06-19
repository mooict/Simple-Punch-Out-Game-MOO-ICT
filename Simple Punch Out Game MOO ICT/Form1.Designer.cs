namespace Simple_Punch_Out_Game_MOO_ICT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boxerHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.boxer = new System.Windows.Forms.PictureBox();
            this.BoxerAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.BoxerMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).BeginInit();
            this.SuspendLayout();
            // 
            // boxerHealthBar
            // 
            this.boxerHealthBar.Location = new System.Drawing.Point(12, 43);
            this.boxerHealthBar.Name = "boxerHealthBar";
            this.boxerHealthBar.Size = new System.Drawing.Size(239, 23);
            this.boxerHealthBar.TabIndex = 0;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(483, 43);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(239, 23);
            this.playerHealthBar.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Simple_Punch_Out_Game_MOO_ICT.Properties.Resources.boxer_stand;
            this.player.Location = new System.Drawing.Point(348, 407);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(61, 153);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // boxer
            // 
            this.boxer.BackColor = System.Drawing.Color.Transparent;
            this.boxer.Image = global::Simple_Punch_Out_Game_MOO_ICT.Properties.Resources.enemy_stand;
            this.boxer.Location = new System.Drawing.Point(404, 321);
            this.boxer.Name = "boxer";
            this.boxer.Size = new System.Drawing.Size(77, 185);
            this.boxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxer.TabIndex = 2;
            this.boxer.TabStop = false;
            // 
            // BoxerAttackTimer
            // 
            this.BoxerAttackTimer.Enabled = true;
            this.BoxerAttackTimer.Interval = 500;
            this.BoxerAttackTimer.Tick += new System.EventHandler(this.BoxerAttackTImerEvent);
            // 
            // BoxerMoveTimer
            // 
            this.BoxerMoveTimer.Enabled = true;
            this.BoxerMoveTimer.Interval = 20;
            this.BoxerMoveTimer.Tick += new System.EventHandler(this.BoxerMoveTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Punch_Out_Game_MOO_ICT.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.player);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.boxerHealthBar);
            this.Controls.Add(this.boxer);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Simple Punch Out Game MOO ICT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar boxerHealthBar;
        private ProgressBar playerHealthBar;
        private PictureBox player;
        private PictureBox boxer;
        private System.Windows.Forms.Timer BoxerAttackTimer;
        private System.Windows.Forms.Timer BoxerMoveTimer;
    }
}