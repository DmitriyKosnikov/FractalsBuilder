using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsDrawer
{
    public class Triangle:Fractal
    {
        /// <summary>
        /// Метод для отрисовки Треугольника.
        /// </summary>
        /// <param name="top_point"></param>
        /// <param name="left_point"></param>
        /// <param name="right_point"></param>
        /// <param name="rec"></param>
        public void DrawTriangle(PointF top_point, PointF left_point, PointF right_point, int rec)
        {
            if (rec == 0)
            {
                // Рисуем треугольник.
                PointF[] points =
                {
                    top_point, right_point, left_point
                };
                Form1.g.FillPolygon(Brushes.Red, points);
            }
            else
            {
                // Находим точки середин.
                PointF left_mid = new PointF(
                    (top_point.X + left_point.X) / 2f,
                    (top_point.Y + left_point.Y) / 2f);
                PointF right_mid = new PointF(
                    (top_point.X + right_point.X) / 2f,
                    (top_point.Y + right_point.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (left_point.X + right_point.X) / 2f,
                    (left_point.Y + right_point.Y) / 2f);

                // Рекусивно рисуем треугольники поменьше.
                DrawTriangle(top_point, left_mid, right_mid, rec - 1);
                DrawTriangle(left_mid, left_point, bottom_mid, rec - 1);
                DrawTriangle(right_mid, bottom_mid, right_point, rec - 1);
            }
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
