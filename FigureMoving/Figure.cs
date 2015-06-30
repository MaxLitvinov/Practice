using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureMoving
{
    abstract class Figure
    {
        public abstract void Draw(Graphics graphics);
        public abstract void Move(int x, int y);
    }
}
