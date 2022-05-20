using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RectangleApp
{
    public class Rectangle
    {
        private double[] _x = new double[4];
        private double[] _y = new double[4];

        public Rectangle() 
        { 
        
        }
        public Rectangle(double[] x, double[] y)
        {
            SetVertices(x, y);
        }
        public void SetVertices(double[] x, double[] y)
        {
            CheckRectangleIsRectangle(x, y);
            for (int i = 0; i < x.Length; i++)
            {
                _x[i] = x[i];
                _y[i] = y[i];
            }
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(_x[2]-_x[0], 2) + Math.Pow(_y[2]-_y[0], 2));
        }
        private void CheckRectangleIsRectangle(double[] x, double[] y)
        {
            double angle1 = (x[1] - x[0]) * (x[3] - x[0]) + (y[1] - y[0]) * (y[3] - y[0]);
            double angle2 = (x[1] - x[2]) * (x[3] - x[2]) + (y[1] - y[2]) * (y[3] - y[0]);
            double height1 = Math.Abs(y[0] - y[1]);
            double height2 = Math.Abs(y[2] - y[3]);
            double width1 = Math.Abs(x[0] - x[3]);
            double width2 = Math.Abs(x[1] - x[2]);
            if (height1 != height2 || width1 != width2)
            {
                if (angle1 != 0 || angle2 != 0)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}