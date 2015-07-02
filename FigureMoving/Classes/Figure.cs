using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureMoving
{
    abstract class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public abstract void Draw(Graphics graphics);

        public abstract void Move(PictureBox pictureBox);
    }
}
