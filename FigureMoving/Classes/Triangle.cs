using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FigureMoving.Classes
{
    class Triangle : Figure
    {
        float x;
        float y;
        float foundation;
        float height;

        public Triangle(float x, float y, float foundation, float height)
        {
            this.x = x;
            this.y = y;
            this.foundation = foundation;
            this.height = height;
        }

        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(new SolidBrush(Color.Blue), 3);
            graphics.DrawLine(pen, this.x, this.y + this.height, this.x + this.foundation, this.y + this.height);
            graphics.DrawLine(pen, this.x, this.y + this.height, this.x + this.foundation / 2, this.y);
            graphics.DrawLine(pen, this.x + this.foundation / 2, this.y, this.x + this.foundation, this.y + this.height);
        }

        public override void Move(PictureBox pictureBox)
        {
            this.x += x;
            this.y += y;
            Draw(pictureBox.CreateGraphics());
        }
    }
}
