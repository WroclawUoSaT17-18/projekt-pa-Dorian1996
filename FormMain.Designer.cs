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
            this.block1 = new System.Windows.Forms.PictureBox();
            this.livesLabel = new System.Windows.Forms.Label();
            this.livesCounterLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreCounterLabel = new System.Windows.Forms.Label();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block3 = new System.Windows.Forms.PictureBox();
            this.block4 = new System.Windows.Forms.PictureBox();
            this.block5 = new System.Windows.Forms.PictureBox();
            this.block6 = new System.Windows.Forms.PictureBox();
            this.block7 = new System.Windows.Forms.PictureBox();
            this.block8 = new System.Windows.Forms.PictureBox();
            this.block9 = new System.Windows.Forms.PictureBox();
            this.block10 = new System.Windows.Forms.PictureBox();
            this.block11 = new System.Windows.Forms.PictureBox();
            this.block12 = new System.Windows.Forms.PictureBox();
            this.block13 = new System.Windows.Forms.PictureBox();
            this.block14 = new System.Windows.Forms.PictureBox();
            this.block15 = new System.Windows.Forms.PictureBox();
            this.block16 = new System.Windows.Forms.PictureBox();
            this.block17 = new System.Windows.Forms.PictureBox();
            this.block18 = new System.Windows.Forms.PictureBox();
            this.block19 = new System.Windows.Forms.PictureBox();
            this.block20 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block20)).BeginInit();
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
            // block1
            // 
            this.block1.Image = ((System.Drawing.Image)(resources.GetObject("block1.Image")));
            this.block1.Location = new System.Drawing.Point(361, 226);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(48, 16);
            this.block1.TabIndex = 2;
            this.block1.TabStop = false;
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
            // block2
            // 
            this.block2.Image = ((System.Drawing.Image)(resources.GetObject("block2.Image")));
            this.block2.Location = new System.Drawing.Point(368, 272);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(48, 16);
            this.block2.TabIndex = 7;
            this.block2.TabStop = false;
            // 
            // block3
            // 
            this.block3.Image = ((System.Drawing.Image)(resources.GetObject("block3.Image")));
            this.block3.Location = new System.Drawing.Point(122, 252);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(48, 16);
            this.block3.TabIndex = 8;
            this.block3.TabStop = false;
            // 
            // block4
            // 
            this.block4.Image = ((System.Drawing.Image)(resources.GetObject("block4.Image")));
            this.block4.Location = new System.Drawing.Point(528, 196);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(48, 16);
            this.block4.TabIndex = 9;
            this.block4.TabStop = false;
            // 
            // block5
            // 
            this.block5.Image = ((System.Drawing.Image)(resources.GetObject("block5.Image")));
            this.block5.Location = new System.Drawing.Point(598, 304);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(48, 16);
            this.block5.TabIndex = 10;
            this.block5.TabStop = false;
            // 
            // block6
            // 
            this.block6.Image = ((System.Drawing.Image)(resources.GetObject("block6.Image")));
            this.block6.Location = new System.Drawing.Point(223, 328);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(48, 16);
            this.block6.TabIndex = 11;
            this.block6.TabStop = false;
            // 
            // block7
            // 
            this.block7.Image = ((System.Drawing.Image)(resources.GetObject("block7.Image")));
            this.block7.Location = new System.Drawing.Point(213, 196);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(48, 16);
            this.block7.TabIndex = 12;
            this.block7.TabStop = false;
            // 
            // block8
            // 
            this.block8.Image = ((System.Drawing.Image)(resources.GetObject("block8.Image")));
            this.block8.Location = new System.Drawing.Point(424, 170);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(48, 16);
            this.block8.TabIndex = 13;
            this.block8.TabStop = false;
            // 
            // block9
            // 
            this.block9.Image = ((System.Drawing.Image)(resources.GetObject("block9.Image")));
            this.block9.Location = new System.Drawing.Point(312, 143);
            this.block9.Name = "block9";
            this.block9.Size = new System.Drawing.Size(48, 16);
            this.block9.TabIndex = 14;
            this.block9.TabStop = false;
            // 
            // block10
            // 
            this.block10.Image = ((System.Drawing.Image)(resources.GetObject("block10.Image")));
            this.block10.Location = new System.Drawing.Point(247, 272);
            this.block10.Name = "block10";
            this.block10.Size = new System.Drawing.Size(48, 16);
            this.block10.TabIndex = 15;
            this.block10.TabStop = false;
            // 
            // block11
            // 
            this.block11.Image = ((System.Drawing.Image)(resources.GetObject("block11.Image")));
            this.block11.Location = new System.Drawing.Point(456, 272);
            this.block11.Name = "block11";
            this.block11.Size = new System.Drawing.Size(48, 16);
            this.block11.TabIndex = 16;
            this.block11.TabStop = false;
            // 
            // block12
            // 
            this.block12.Image = ((System.Drawing.Image)(resources.GetObject("block12.Image")));
            this.block12.Location = new System.Drawing.Point(312, 328);
            this.block12.Name = "block12";
            this.block12.Size = new System.Drawing.Size(48, 16);
            this.block12.TabIndex = 17;
            this.block12.TabStop = false;
            // 
            // block13
            // 
            this.block13.Image = ((System.Drawing.Image)(resources.GetObject("block13.Image")));
            this.block13.Location = new System.Drawing.Point(424, 304);
            this.block13.Name = "block13";
            this.block13.Size = new System.Drawing.Size(48, 16);
            this.block13.TabIndex = 18;
            this.block13.TabStop = false;
            // 
            // block14
            // 
            this.block14.Image = ((System.Drawing.Image)(resources.GetObject("block14.Image")));
            this.block14.Location = new System.Drawing.Point(377, 328);
            this.block14.Name = "block14";
            this.block14.Size = new System.Drawing.Size(48, 16);
            this.block14.TabIndex = 19;
            this.block14.TabStop = false;
            // 
            // block15
            // 
            this.block15.Image = ((System.Drawing.Image)(resources.GetObject("block15.Image")));
            this.block15.Location = new System.Drawing.Point(504, 304);
            this.block15.Name = "block15";
            this.block15.Size = new System.Drawing.Size(48, 16);
            this.block15.TabIndex = 20;
            this.block15.TabStop = false;
            // 
            // block16
            // 
            this.block16.Image = ((System.Drawing.Image)(resources.GetObject("block16.Image")));
            this.block16.Location = new System.Drawing.Point(122, 354);
            this.block16.Name = "block16";
            this.block16.Size = new System.Drawing.Size(48, 16);
            this.block16.TabIndex = 21;
            this.block16.TabStop = false;
            // 
            // block17
            // 
            this.block17.Image = ((System.Drawing.Image)(resources.GetObject("block17.Image")));
            this.block17.Location = new System.Drawing.Point(456, 354);
            this.block17.Name = "block17";
            this.block17.Size = new System.Drawing.Size(48, 16);
            this.block17.TabIndex = 22;
            this.block17.TabStop = false;
            // 
            // block18
            // 
            this.block18.Image = ((System.Drawing.Image)(resources.GetObject("block18.Image")));
            this.block18.Location = new System.Drawing.Point(528, 354);
            this.block18.Name = "block18";
            this.block18.Size = new System.Drawing.Size(48, 16);
            this.block18.TabIndex = 23;
            this.block18.TabStop = false;
            // 
            // block19
            // 
            this.block19.Image = ((System.Drawing.Image)(resources.GetObject("block19.Image")));
            this.block19.Location = new System.Drawing.Point(598, 376);
            this.block19.Name = "block19";
            this.block19.Size = new System.Drawing.Size(48, 16);
            this.block19.TabIndex = 24;
            this.block19.TabStop = false;
            // 
            // block20
            // 
            this.block20.Image = ((System.Drawing.Image)(resources.GetObject("block20.Image")));
            this.block20.Location = new System.Drawing.Point(233, 376);
            this.block20.Name = "block20";
            this.block20.Size = new System.Drawing.Size(48, 16);
            this.block20.TabIndex = 25;
            this.block20.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.block20);
            this.Controls.Add(this.block19);
            this.Controls.Add(this.block18);
            this.Controls.Add(this.block17);
            this.Controls.Add(this.block16);
            this.Controls.Add(this.block15);
            this.Controls.Add(this.block14);
            this.Controls.Add(this.block13);
            this.Controls.Add(this.block12);
            this.Controls.Add(this.block11);
            this.Controls.Add(this.block10);
            this.Controls.Add(this.block9);
            this.Controls.Add(this.block8);
            this.Controls.Add(this.block7);
            this.Controls.Add(this.block6);
            this.Controls.Add(this.block5);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.scoreCounterLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.livesCounterLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.block1);
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
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerRefresh;
        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label livesCounterLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreCounterLabel;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox block3;
        private System.Windows.Forms.PictureBox block4;
        private System.Windows.Forms.PictureBox block5;
        private System.Windows.Forms.PictureBox block6;
        private System.Windows.Forms.PictureBox block7;
        private System.Windows.Forms.PictureBox block8;
        private System.Windows.Forms.PictureBox block9;
        private System.Windows.Forms.PictureBox block10;
        private System.Windows.Forms.PictureBox block11;
        private System.Windows.Forms.PictureBox block12;
        private System.Windows.Forms.PictureBox block13;
        private System.Windows.Forms.PictureBox block14;
        private System.Windows.Forms.PictureBox block15;
        private System.Windows.Forms.PictureBox block16;
        private System.Windows.Forms.PictureBox block17;
        private System.Windows.Forms.PictureBox block18;
        private System.Windows.Forms.PictureBox block19;
        private System.Windows.Forms.PictureBox block20;
    }
}

