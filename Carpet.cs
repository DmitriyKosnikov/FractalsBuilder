using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalsDrawer
{
    public class Carpet:Fractal
    {
        /// <summary>
        /// Метод для рисования Ковра.
        /// </summary>
        /// <param name="recur"></param>
        /// <param name="rect"></param>
        public void DrawRectangle(int recur, RectangleF rect)
        {
            if (recur == 0)
            {
                // Рисуем Ковер.
                Form1.g.FillRectangle(Brushes.Blue, rect);
            }
            else
            {
                // Разделяем ковер на 9 частей.
                float wid = rect.Width / 3f;
                float x0 = rect.Left;
                float x1 = x0 + wid;
                float x2 = x0 + wid * 2f;

                float hgt = rect.Height / 3f;
                float y0 = rect.Top;
                float y1 = y0 + hgt;
                float y2 = y0 + hgt * 2f;

                // Рекурсивно рисуем меньшие ковры.
                DrawRectangle(recur - 1, new RectangleF(x0, y0, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x1, y0, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x2, y0, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x0, y1, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x2, y1, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x0, y2, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x1, y2, wid, hgt));
                DrawRectangle(recur - 1, new RectangleF(x2, y2, wid, hgt));
            }
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
