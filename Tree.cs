using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace FractalsDrawer
{
    public class Tree:Fractal
    {
        //Создаем поля для углов и коэффициента уменьшения длины.
        double cf;
        public double angle1;
        public double angle2;

        public Tree(double Angle1, double Angle2, double CF)
        {
            angle1 = Angle1;
            angle2 = Angle2;
            cf = CF;
        }
        public double angle = Math.PI / 2;
        
        /// <summary>
        /// Метод для отрисовки дерева.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="len"></param>
        /// <param name="angle"></param>
        /// <param name="recur"></param>
        public void DrawTree(int x, int y, double len, double angle, int recur)
        {
            if ((recur > 0) && (len >= 1))
            {
                len *= cf;
                //Считаем координаты для вершины-ребенка.
                int xnew = (int)(x + len * Math.Cos(angle)),
                    ynew = (int)(y - len * Math.Sin(angle));
                //рисуем линию между точками.
                Form1.g.DrawLine(new Pen(Color.Black), (int)x, (int)y, (int)xnew, (int)ynew);
                //Вызываем рекурсивную функцию для левого и правого ребенка.
                DrawTree(xnew, ynew, len, (angle + angle1), recur - 1);
                DrawTree(xnew, ynew, len, (angle - angle2), recur - 1);
            }
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
