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
        public int X { get; private set; }
        public int Y { get; private set; }

        public abstract void Draw(Graphics graphics);

        public abstract void Move(PictureBox pictureBox);
    }
}
