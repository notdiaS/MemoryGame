namespace MemoryGame
{
    partial class GameScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            ButtonRestart = new Button();
            LabelP1 = new Label();
            LabelP2 = new Label();
            LabelTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            TimerGame = new System.Windows.Forms.Timer(components);
            LabelScoreP1 = new Label();
            LabelScoreP2 = new Label();
            LabelP1Turn = new Label();
            LabelP2Turn = new Label();
            SuspendLayout();
            // 
            // ButtonRestart
            // 
            ButtonRestart.BackColor = Color.Transparent;
            ButtonRestart.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonRestart.ForeColor = SystemColors.ActiveCaptionText;
            ButtonRestart.Location = new Point(347, 512);
            ButtonRestart.Name = "ButtonRestart";
            ButtonRestart.Size = new Size(199, 64);
            ButtonRestart.TabIndex = 0;
            ButtonRestart.Text = "Restart";
            ButtonRestart.UseVisualStyleBackColor = false;
            ButtonRestart.Click += RestartGameEvent;
            // 
            // LabelP1
            // 
            LabelP1.AutoSize = true;
            LabelP1.BackColor = Color.Transparent;
            LabelP1.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelP1.ForeColor = Color.Maroon;
            LabelP1.Location = new Point(103, 136);
            LabelP1.Name = "LabelP1";
            LabelP1.Size = new Size(91, 30);
            LabelP1.TabIndex = 1;
            LabelP1.Text = "Player 1";
            // 
            // LabelP2
            // 
            LabelP2.AutoSize = true;
            LabelP2.BackColor = Color.Transparent;
            LabelP2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelP2.ForeColor = Color.Blue;
            LabelP2.Location = new Point(705, 136);
            LabelP2.Name = "LabelP2";
            LabelP2.Size = new Size(89, 28);
            LabelP2.TabIndex = 2;
            LabelP2.Text = "Player 2";
            // 
            // LabelTimer
            // 
            LabelTimer.AutoSize = true;
            LabelTimer.BackColor = Color.Transparent;
            LabelTimer.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTimer.ForeColor = Color.Indigo;
            LabelTimer.Location = new Point(382, 32);
            LabelTimer.Name = "LabelTimer";
            LabelTimer.Size = new Size(140, 31);
            LabelTimer.TabIndex = 3;
            LabelTimer.Text = "Time Left: 5";
            // 
            // TimerGame
            // 
            TimerGame.Interval = 1000;
            TimerGame.Tick += TimerEvent;
            // 
            // LabelScoreP1
            // 
            LabelScoreP1.AutoSize = true;
            LabelScoreP1.BackColor = Color.Transparent;
            LabelScoreP1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelScoreP1.ForeColor = Color.FromArgb(64, 0, 0);
            LabelScoreP1.Location = new Point(103, 178);
            LabelScoreP1.Name = "LabelScoreP1";
            LabelScoreP1.Size = new Size(68, 20);
            LabelScoreP1.TabIndex = 4;
            LabelScoreP1.Text = "Score: 0";
            // 
            // LabelScoreP2
            // 
            LabelScoreP2.AutoSize = true;
            LabelScoreP2.BackColor = Color.Transparent;
            LabelScoreP2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelScoreP2.ForeColor = Color.FromArgb(0, 0, 64);
            LabelScoreP2.Location = new Point(705, 178);
            LabelScoreP2.Name = "LabelScoreP2";
            LabelScoreP2.Size = new Size(68, 20);
            LabelScoreP2.TabIndex = 5;
            LabelScoreP2.Text = "Score: 0";
            // 
            // LabelP1Turn
            // 
            LabelP1Turn.AutoSize = true;
            LabelP1Turn.BackColor = Color.Transparent;
            LabelP1Turn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelP1Turn.ForeColor = Color.Transparent;
            LabelP1Turn.Location = new Point(209, 136);
            LabelP1Turn.Name = "LabelP1Turn";
            LabelP1Turn.Size = new Size(40, 28);
            LabelP1Turn.TabIndex = 6;
            LabelP1Turn.Text = "<=";
            // 
            // LabelP2Turn
            // 
            LabelP2Turn.AutoSize = true;
            LabelP2Turn.BackColor = Color.Transparent;
            LabelP2Turn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelP2Turn.ForeColor = Color.Transparent;
            LabelP2Turn.Location = new Point(627, 136);
            LabelP2Turn.Name = "LabelP2Turn";
            LabelP2Turn.Size = new Size(40, 28);
            LabelP2Turn.TabIndex = 7;
            LabelP2Turn.Text = "=>";
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(895, 601);
            Controls.Add(LabelP2Turn);
            Controls.Add(LabelP1Turn);
            Controls.Add(LabelScoreP2);
            Controls.Add(LabelScoreP1);
            Controls.Add(LabelTimer);
            Controls.Add(LabelP2);
            Controls.Add(LabelP1);
            Controls.Add(ButtonRestart);
            Name = "GameScreen";
            Text = "Memory Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonRestart;
        private Label LabelP1;
        private Label LabelP2;
        private Label LabelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TimerGame;
        private Label LabelScoreP1;
        private Label LabelScoreP2;
        private Label LabelP1Turn;
        private Label LabelP2Turn;
    }
}