using FigureMoving.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FigureMoving
{
    public partial class FigureMovingForm : Form
    {
        private List<Figure> figureList;
        
        private Random random;

        public FigureMovingForm()
        {
            InitializeComponent();
            figureList = new List<Figure>();
            random = new Random();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            float radius = random.Next(10, 50);
            float x = random.Next(0, pictureBox.Width - (int)radius);
            float y = random.Next(0, pictureBox.Height - (int)radius);
            Figure circle = new Circle(x, y, radius);
            figureList.Add(circle);
            figureTreeView.Nodes.Add(circle.GetType().Name.ToString());
            circle.Draw(graphics);
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            float width = random.Next(50, 100);
            float height = random.Next(50, 100);
            float x = random.Next(0, pictureBox.Width - (int)width);
            float y = random.Next(0, pictureBox.Height - (int)height);
            Figure triangle = new Triangle(x, y, width, height);
            figureList.Add(triangle);
            figureTreeView.Nodes.Add(triangle.GetType().Name.ToString());
            triangle.Draw(graphics);
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            float width = random.Next(10, 50);
            float height = random.Next(10, 50);
            float x = random.Next(0, pictureBox.Width - (int)width);
            float y =  random.Next(0, pictureBox.Height - (int)height);
            Figure rectangle = new Rectangle(x, y, width, height);
            figureList.Add(rectangle);
            figureTreeView.Nodes.Add(rectangle.GetType().Name.ToString());
            rectangle.Draw(graphics);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            moveButton.Text = "Stop";
        }

        private void figureTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (timer.Enabled)
            {
                Graphics graphics = pictureBox.CreateGraphics();
                graphics.Clear(pictureBox.BackColor);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.Clear(pictureBox.BackColor);
            foreach (Figure figure in figureList)
            {
                figure.Move(pictureBox);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "";
            foreach(Figure figure in figureList)
            {
                s += figure.GetType().Name.ToString() + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
