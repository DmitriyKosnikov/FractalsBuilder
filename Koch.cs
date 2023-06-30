using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalsDrawer
{
    public class Koch:Fractal
    {
        /// <summary>
        /// Метод для отрисовки кривой Коха
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="rec"></param>
        public void DrawKoch(PointF p1, PointF p2, PointF p3, int rec)
        {
            if (rec > 0)
            {

                if (rec > 0)
                { 
                    //средняя треть отрезка
                    var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                    var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                    //координаты вершины угла
                    var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                    var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                    //рисуем его
                    Form1.g.DrawLine(new Pen(Color.Blue), p4, pn);
                    Form1.g.DrawLine(new Pen(Color.Blue), p5, pn);
                    Form1.g.DrawLine(new Pen(Color.Blue), p4, p5);


                    //рекурсивно вызываем функцию нужное число раз
                    DrawKoch(p4, pn, p5, rec - 1);
                    DrawKoch(pn, p5, p4, rec - 1);
                    DrawKoch(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), rec - 1);
                    DrawKoch(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), rec - 1);
                }
            }
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
