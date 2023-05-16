﻿using ArinaWorld;
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
        Point mousePosition;
        public MapForm()
        {
            InitializeComponent();

        }

        Point RotateTrasform(Point p)
        {
            double multipierY = Math.Cos((double)Var.RotateAngleY / 180);
            double multipierZ1 = Math.Cos((double)Var.RotateAngleZ / 180);
            double multipierZ2 = Math.Sin((double)Var.RotateAngleZ / 180);
            p = new Point((int)(p.X * multipierZ1 - p.Y * multipierZ2), (int)((p.Y * multipierZ1 + p.X * multipierZ2) * multipierY));
            return p;
        }

        public void DrawMap(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            if (Var.Map == null || Var.Map.Grids == null)
                return;

            g.Clear(BackColor);            
            for (int i = 0; i < Var.Map.Grids.GetLength(0); i++)
            {
                for (int j = 0; j < Var.Map.Grids.GetLength(1); j++)
                {
                    Point[] points = new Point[4];
                    int radius = Var.AmplificationFactor * Var.Map.Grids.GetLength(0) / 2;
                    int x = i * Var.AmplificationFactor - radius;
                    int y = j * Var.AmplificationFactor - radius;

                    points[0] = new Point(x, y);
                    points[1] = new Point(x + Var.AmplificationFactor, y);
                    points[2] = new Point(x + Var.AmplificationFactor, y + Var.AmplificationFactor);
                    points[3] = new Point(x, y + Var.AmplificationFactor);
                    //Transform Rule
                    //x = xcosT - ysinT
                    //y = ycosT + xsinT
                    for (int k = 0; k < 4; k++)
                    {
                        points[k] = RotateTrasform(points[k]);
                        points[k] = new Point(points[k].X + radius * 2, points[k].Y + radius * 2);
                        //points[k] = new Point((int)(points[k].X * multipierZ1 - points[k].Y * multipierZ2),
                        //    (int)(points[k].Y * multipierZ1 + points[k].X * multipierZ2));
                        //points[k] = new Point(points[k].X, (int)(points[k].Y * multipierY));
                        //points[k] = new Point(points[k].X + radius * 2, points[k].Y + radius * 2);
                    }
                    g.DrawPolygon(pen, points);
                }
            }
            g.Flush();

        }

        public void RotateLeft(int amount = 10)
        {
            Var.RotateAngleZ -= Math.Abs(amount);
            Invalidate();
        }

        public void RotateRight(int amount = 10)
        {
            Var.RotateAngleZ += Math.Abs(amount);
            Invalidate();
        }

        public void RotateUp(int amount = 10)
        {
            if (Var.RotateAngleY > -180)
                Var.RotateAngleY -= Math.Abs(amount);
            else
                return;
            if (Var.RotateAngleY < -180)
                Var.RotateAngleY = -180;
            Invalidate();
        }

        public void RotateDown(int amount = 10)
        {
            if (Var.RotateAngleY < 0)
                Var.RotateAngleY += Math.Abs(amount);
            else
                return;
            if (Var.RotateAngleY > 0)
                Var.RotateAngleY = 0;
            Invalidate();
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
        }

        private void MapForm_Paint(object sender, PaintEventArgs e)
        {
            DrawMap(e.Graphics);
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


        private void MapForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mousePosition != Point.Empty)
                {
                    if (mousePosition.X - e.X > 0)
                        RotateRight(mousePosition.X - e.X);
                    else if (mousePosition.X - e.X < 0)
                        RotateLeft(e.X - mousePosition.X);
                    if (mousePosition.Y - e.Y > 0)
                        RotateDown(mousePosition.Y - e.Y);
                    else if (mousePosition.Y - e.Y < 0)
                        RotateUp(e.Y - mousePosition.Y);
                }
                mousePosition = e.Location;
            }
        }
    }
}
