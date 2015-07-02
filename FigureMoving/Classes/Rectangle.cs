using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureMoving
{
    class Rectangle : Figure
    {
        float x;
        float y;

        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.Width = width;
            this.Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(new SolidBrush(Color.Red), 3);
            graphics.DrawRectangle(pen, this.x, this.y, this.Width, this.Height);
        }

        public override void Move(PictureBox pictureBox)
        {
            this.x += x;
            this.y += y;
            Draw(pictureBox.CreateGraphics());
        }
    }
}
