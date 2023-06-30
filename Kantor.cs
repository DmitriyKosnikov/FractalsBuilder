using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalsDrawer
{
    public class Kantor:Fractal
    {
        /// <summary>
        /// Метод для отрисовки множества Кантора.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="len"></param>
        /// <param name="distance"></param>
        /// <param name="rec"></param>
        public void DrawK(int x, int y, double len, double distance, int rec)
        {
            if (rec > 0)
            {
                // Рисуем линию.
                int xnew = (int)(x + len);
                Form1.g.DrawLine(new Pen(Color.Black, 5), x, y, xnew, y);
                // Находим координаты для новой линии.
                int ynew = y + (int)distance;
                len /= 3;
                xnew -= (int)len;
                rec -= 1;
                // Рекурсивно рисуем следующие линии.
                DrawK(x, ynew, len, distance, rec);
                DrawK(xnew, ynew, len, distance, rec);
            }
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
