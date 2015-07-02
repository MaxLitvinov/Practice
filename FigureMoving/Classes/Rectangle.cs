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
        Pen pen = new Pen(new SolidBrush(Color.Red), 3);

        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float x, float y, float width, float height) : base(x, y)
        {
            this.Width = width;
            this.Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, 80, 80, 200, 100);
        }

        public override void Move(PictureBox pictureBox)
        {

        }
    }
}
