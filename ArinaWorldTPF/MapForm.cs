using ArinaWorld;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

namespace ArinaWorldTPF
{
    public partial class MapForm : Form
    {
        public Graphics graphic;
        public MapForm()
        {
            InitializeComponent();
        }

        public void DrawMap()
        {
            Pen pen = new Pen(Color.Black, 2);
            if (Var.Map == null || Var.Map.Grids == null)
                return;
            
            graphic.Clear(Color.White);
            for (int i = 0; i < Var.Map.Grids.GetLength(0); i++)
            {
                for (int j = 0; j < Var.Map.Grids.GetLength(1); j++)
                {    
                    Point[] points = new Point[4];
                    int radius = Var.AmplificationFactor * Var.Map.Grids.GetLength(0);                    
                    int x = i * Var.AmplificationFactor - radius;
                    int y = j * Var.AmplificationFactor - radius;
                    double multipierY = Math.Cos((double)Var.RotateAngleY / 180);
                    double multipierZ1 = Math.Cos((double)Var.RotateAngleZ / 180);
                    double multipierZ2 = Math.Sin((double)Var.RotateAngleZ / 180);
                    points[0] = new Point(x, y);
                    points[1] = new Point(x + Var.AmplificationFactor, y);
                    points[2] = new Point(x + Var.AmplificationFactor, y + Var.AmplificationFactor);
                    points[3] = new Point(x, y + Var.AmplificationFactor);
                    //Transform Rule
                    //x = xcosT - ysinT
                    //y = ycosT + xsinT
                    for (int k = 0; k < 4; k++)
                    {
                        points[k] = new Point((int)(points[k].X * multipierZ1 - points[k].Y * multipierZ2),
                            (int)(points[k].Y * multipierZ1 + points[k].X * multipierZ2));
                        points[k] = new Point(points[k].X, (int)(points[k].Y * multipierY));
                        points[k] = new Point(points[k].X + radius, points[k].Y + radius);
                    }
                    graphic.DrawPolygon(pen, points);
                }
            }
            graphic.Flush();
        }

        public void RotateLeft()
        {
            Var.RotateAngleZ -= 10;
            DrawMap();
        }

        public void RotateRight()
        {
            Var.RotateAngleZ += 10;
            DrawMap();
        }

        public void RotateUp()
        {
            Var.RotateAngleY -= 10;
            DrawMap();
        }

        public void RotateDown()
        {
            Var.RotateAngleY += 10;
            DrawMap();
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            //Temp
            Var.Map = new Map();
            Var.Map.Name = "TestMap";
            Var.Map.Grids = new Grid[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Var.Map.Grids[i, j] = new Grid();
                }
            }
            graphic = CreateGraphics();
        }

        private void MapForm_Paint(object sender, PaintEventArgs e)
        {
            DrawMap();
        }

        private void MapForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'q':
                    RotateLeft();
                    break;
                case 'e':
                    RotateRight();                
                    break;
                case 'w':
                    RotateUp();
                    break;
                case 's':
                    RotateDown();
                    break;

            }
        }
    }
}
