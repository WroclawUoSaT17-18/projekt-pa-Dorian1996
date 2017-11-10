using System;
using System.Windows.Forms;

namespace Arkanoid2
{
    partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.PictureBox();
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle
            // 
            this.paddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paddle.BackColor = System.Drawing.Color.Transparent;
            this.paddle.Image = ((System.Drawing.Image)(resources.GetObject("paddle.Image")));
            this.paddle.Location = new System.Drawing.Point(363, 545);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(64, 16);
            this.paddle.TabIndex = 0;
            this.paddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(389, 545);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(8, 8);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // block
            // 
            this.block.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block.BackColor = System.Drawing.Color.Transparent;
            this.block.Image = ((System.Drawing.Image)(resources.GetObject("block.Image")));
            this.block.Location = new System.Drawing.Point(379, 12);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(48, 16);
            this.block.TabIndex = 2;
            this.block.TabStop = false;
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Enabled = true;
            this.TimerRefresh.Interval = 1;
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.block);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Arkanoid Dorian Antonkiewicz";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox paddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox block;
        private System.Windows.Forms.Timer TimerRefresh;
    }
}

