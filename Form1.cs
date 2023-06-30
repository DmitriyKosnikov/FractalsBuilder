using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsDrawer
{
    public partial class Form1 : Form
    { 
        // Создаем переменную для определения выбранной команды.
        string currentCommand = "0";
        // Переменная для определения нажата ли кнопка "Рисуй!".
        bool flag = false;
        // Создаем для графики.
        Bitmap bitmap;
        public static Graphics g { get; set; }
        /// <summary>
        /// Метод для считывания угла с trackbar.
        /// </summary>
        /// <returns></returns>
        public double GetAngle1()
        {
            double angle = angleBar1.Value*Math.PI/180;
            return angle;
        }
        /// <summary>
        /// Метод для считывания угла с trackbar.
        /// </summary>
        /// <returns></returns>
        public double GetAngle2()
        {
            double angle = angleBar2.Value*Math.PI/180;
            return angle;
        }
        

        public Form1()
        {
            InitializeComponent();
            // Делаем так чтобы максимальный угол был 90 градусов.
            angleBar1.Maximum = 90;
            angleBar2.Maximum = 90;
            recLabel.Text = $"Глубина рекурсии:{RecurBar.Value}";
            angleLabel1.Text = $"Первый угол:{angleBar1.Value}";
            angleLabel2.Text = $"Второй угол:{angleBar2.Value}";
            
            MaximumSize = SystemInformation.PrimaryMonitorSize;
            MinimumSize = new Size(MaximumSize.Width / 2, MaximumSize.Height / 2);
            
            
            
            
        }
        /// <summary>
        /// Метод нужен чтобы скрыть неиспользуемые элементы.
        /// </summary>
        public void Visible0() 
        {
            angleBar1.Visible = false;
            angleLabel1.Visible = false;
            angleBar2.Visible = false;
            angleLabel2.Visible = false;
            label4.Visible = false;
            trackBar4.Visible = false;
        }

        private void AngleBar1_Scroll(object sender, EventArgs e)
        {
            angleLabel1.Text = $"Первый угол:{angleBar1.Value}";
        }

        private void AngleBar2_Scroll(object sender, EventArgs e)
        {
            angleLabel2.Text = $"Второй угол:{angleBar2.Value}";
        }

        private void RecurBar_Scroll(object sender, EventArgs e)
        {
            recLabel.Text = $"Глубина рекурсии:{RecurBar.Value}";
        }
        
        private void treeButton_Click(object sender, EventArgs e)
        {
            currentCommand = "1";
            // Делаем необходимые элементы видимыми.
            angleBar1.Visible = true;
            angleLabel1.Visible = true;
            angleBar2.Visible = true;
            angleLabel2.Visible = true;
            label4.Visible = true;
            trackBar4.Visible = true;

            trackBar4.Maximum = 80;
            trackBar4.Minimum = 50;
            label4.Text = $"следующая линия:{trackBar4.Value * 0.01} от предыдущей";

        }

        private void koch_Click(object sender, EventArgs e)
        {
            currentCommand = "2";
            Visible0();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            // Сделано для того, чтобы значения на trackBar менялись в зависимости от выбранной команды.
            if (currentCommand == "1")
            {
                label4.Text = $"Следующая часть дерева:{trackBar4.Value * 0.01} от предыдущей";
            }
            else if (currentCommand == "5")
            {
                label4.Text = $"Расстояние между прямыми:{trackBar4.Value}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentCommand = "3";
            Visible0();
            RecurBar.Maximum = 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentCommand = "4";
            // Сделал максимальное количество рекурсий 6, т.к. при значениях больше 7 программа зависает.
            RecurBar.Maximum = 6;
            Visible0();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentCommand = "5";
            // Делаем необходимый trackbar видимым.
            angleBar1.Visible = false;
            angleLabel1.Visible = false;
            angleBar2.Visible = false;
            angleLabel2.Visible = false;
            label4.Visible = true;
            trackBar4.Visible = true;
            RecurBar.Maximum = 7;
            trackBar4.Maximum = 100;
            trackBar4.Minimum = 50;
            label4.Text = $"расстояние между прямыми:{trackBar4.Value}";

        }
        public void Tree()
        {

        }
        /// <summary>
        /// Метод который определяет какую функцию рисовать при нажатии кнопки "Рисуй!".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            switch (currentCommand) 
            {
                case "0":
                    {
                        MessageBox.Show("Вы не выбрали какой фрактал рисовать :(");
                        break;
                    }
                case "1":
                    {
                        flag = true;
                        TreeChange();
                        break;
                    }
                case "2":
                    {
                        flag = true;
                        Koch();
                        break;
                    }
                case "3":
                    {
                        flag = true;
                        Triangle();
                        break;
                    }
                case "4":
                    {
                        flag = true;
                        Carpet();
                        break;
                    }
                case "5":
                    {
                        flag = true;
                        Cantor();
                        break;
                    }
            } 
        }
        // Сделано чтоб при изменении trackBar рекурсий картинка автоматически перерисовывалась.
        private void RecurBar_ValueChanged(object sender, EventArgs e)
        {
            // Работает только если нажата кнопка "Рисуй!".
            if (flag)
            {
                if (currentCommand == "1")
                    TreeChange();
                else if (currentCommand == "2")
                    Koch();
                else if (currentCommand == "3")
                    Triangle();
                else if (currentCommand == "4")
                    Carpet();
                else if (currentCommand == "5")
                    Cantor();
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            
        }
        // Сделано чтобы при изменении размера окна картинка автоматически перерисовывалась
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Работает только если нажата кнопка "Рисуй!".
            if (flag)
            {
                if (currentCommand == "1")
                    TreeChange();
                else if (currentCommand == "2")
                    Koch();
                else if (currentCommand == "3")
                    Triangle();
                else if (currentCommand == "4")
                    Carpet();
                else if (currentCommand == "5")
                    Cantor();
            }
        }
        /// <summary>
        /// Метод для отрисовки дерева в форме.
        /// </summary>
        public void TreeChange()
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.LightYellow);
            // Создаем дерево и рисуем его.
            Tree tree = new Tree(GetAngle1(), GetAngle2(), trackBar4.Value * 0.01);
            tree.DrawTree(panel1.Width / 2, panel1.Height/2, panel1.Height / 8, Math.PI / 2, RecurBar.Value);
            pictureBox1.Image = bitmap;
        }
        /// <summary>
        /// Метод для отрисовки множества Кантора в форме.
        /// </summary>
        public void Cantor()
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.LightYellow);
            // Создаем множество и рисуем его.
            Kantor kantor = new Kantor();
            kantor.DrawK(panel1.Width/8, panel1.Height/8, panel1.Width * 0.8, trackBar4.Value, RecurBar.Value);
            pictureBox1.Image = bitmap;
        }
        /// <summary>
        /// Метод для отрисовки ковра Серпинского в форме.
        /// </summary>
        public void Carpet()
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.LightYellow);
            // Создаем ковер и рисуем его.
            Carpet carpet = new Carpet();
            carpet.DrawRectangle(RecurBar.Value, new RectangleF(panel1.Width/4, panel1.Height/4, panel1.Width/2, panel1.Height/2)); ;
            pictureBox1.Image = bitmap;
        }
        /// <summary>
        /// Метод для отрисовки треугольника Серпинского в форме.
        /// </summary>
        public void Triangle()
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.LightYellow);
            // Создаем треугольнк и рисуем его.
            Triangle triangle = new Triangle();
            triangle.DrawTriangle(new PointF(panel1.Width / 2, panel1.Height / 2), new PointF(0, panel1.Height), new PointF(panel1.Width, panel1.Height), RecurBar.Value);
            pictureBox1.Image = bitmap;
        }
        public void Koch()
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.LightYellow);
            // Создаем кривую и рисуем его.
            g.DrawLine(new Pen(Color.Blue), new PointF(0, panel1.Height / 2), new PointF(panel1.Width, panel1.Height / 2));
            Koch koch = new Koch();
            koch.DrawKoch(new PointF(0, panel1.Height / 2), new PointF(panel1.Width, panel1.Height / 2), new PointF(panel1.Width / 2, panel1.Height / 4), RecurBar.Value);
            pictureBox1.Image = bitmap;
        }

    }
}
