namespace projekt_pa_Dorian1996
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.paddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.livesLabel = new System.Windows.Forms.Label();
            this.livesCounterLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreCounterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Enabled = true;
            this.TimerRefresh.Interval = 1;
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // paddle
            // 
            this.paddle.Image = ((System.Drawing.Image)(resources.GetObject("paddle.Image")));
            this.paddle.Location = new System.Drawing.Point(361, 423);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(64, 16);
            this.paddle.TabIndex = 0;
            this.paddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(389, 409);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(8, 8);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.livesLabel.Location = new System.Drawing.Point(12, 9);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(100, 23);
            this.livesLabel.TabIndex = 3;
            this.livesLabel.Text = "Życia :";
            // 
            // livesCounterLabel
            // 
            this.livesCounterLabel.AutoSize = true;
            this.livesCounterLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesCounterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.livesCounterLabel.Location = new System.Drawing.Point(118, 9);
            this.livesCounterLabel.Name = "livesCounterLabel";
            this.livesCounterLabel.Size = new System.Drawing.Size(0, 23);
            this.livesCounterLabel.TabIndex = 4;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(12, 32);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(101, 23);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Wynik :";
            // 
            // scoreCounterLabel
            // 
            this.scoreCounterLabel.AutoSize = true;
            this.scoreCounterLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCounterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreCounterLabel.Location = new System.Drawing.Point(118, 32);
            this.scoreCounterLabel.Name = "scoreCounterLabel";
            this.scoreCounterLabel.Size = new System.Drawing.Size(0, 23);
            this.scoreCounterLabel.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.scoreCounterLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.livesCounterLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Name = "FormMain";
            this.Text = "Arkanoid";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerRefresh;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label livesCounterLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreCounterLabel;
    }
}

