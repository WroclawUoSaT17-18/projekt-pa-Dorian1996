using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Direction
        {
            Left, Right, None
        }

        private int paddle_x;
        private int paddle_y;
        private Direction paddle_direction;
        public Form1()
        {
            InitializeComponent();

            paddle_x = 375;
            paddle_y = 500;
            paddle_direction = Direction.None;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, paddle_x, paddle_y, 50, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(paddle_direction == Direction.Right)
            {
                paddle_x += 6;
            }
            else if(paddle_direction == Direction.Left)
            {
                paddle_x -= 6;
            }
            else if (paddle_direction == Direction.Left)
            {
                paddle_x += 0;
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                paddle_direction = Direction.Left;
            }
            else if(e.KeyCode == Keys.Right)
            {
                paddle_direction = Direction.Right;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paddle_direction = Direction.None;
            }
            else if (e.KeyCode == Keys.Right)
            {
                paddle_direction = Direction.None;
            }
        }
    }
}
