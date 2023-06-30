namespace FractalsDrawer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeButton = new System.Windows.Forms.Button();
            this.koch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.recLabel = new System.Windows.Forms.Label();
            this.RecurBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.angleLabel1 = new System.Windows.Forms.Label();
            this.angleBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.angleLabel2 = new System.Windows.Forms.Label();
            this.angleBar2 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecurBar)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar2)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.treeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.koch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeButton
            // 
            this.treeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeButton.Location = new System.Drawing.Point(3, 3);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(152, 47);
            this.treeButton.TabIndex = 0;
            this.treeButton.Text = "Обдуваемое ветром дерево";
            this.treeButton.UseVisualStyleBackColor = true;
            this.treeButton.Click += new System.EventHandler(this.treeButton_Click);
            // 
            // koch
            // 
            this.koch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koch.Location = new System.Drawing.Point(161, 3);
            this.koch.Name = "koch";
            this.koch.Size = new System.Drawing.Size(152, 47);
            this.koch.TabIndex = 1;
            this.koch.Text = "Кривая Коха";
            this.koch.UseVisualStyleBackColor = true;
            this.koch.Click += new System.EventHandler(this.koch_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(319, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Треугольник Серпинского";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(477, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ковер Серпинского";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(635, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "Множество кантора";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.recLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RecurBar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(152, 47);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // recLabel
            // 
            this.recLabel.AutoSize = true;
            this.recLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recLabel.Location = new System.Drawing.Point(3, 23);
            this.recLabel.Name = "recLabel";
            this.recLabel.Size = new System.Drawing.Size(146, 24);
            this.recLabel.TabIndex = 1;
            this.recLabel.Text = "Введите кол-во рекурсий";
            // 
            // RecurBar
            // 
            this.RecurBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecurBar.Location = new System.Drawing.Point(3, 3);
            this.RecurBar.Name = "RecurBar";
            this.RecurBar.Size = new System.Drawing.Size(146, 17);
            this.RecurBar.TabIndex = 2;
            this.RecurBar.Scroll += new System.EventHandler(this.RecurBar_Scroll);
            this.RecurBar.ValueChanged += new System.EventHandler(this.RecurBar_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.angleLabel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.angleBar1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(161, 56);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(152, 47);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // angleLabel1
            // 
            this.angleLabel1.AutoSize = true;
            this.angleLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angleLabel1.Location = new System.Drawing.Point(3, 23);
            this.angleLabel1.Name = "angleLabel1";
            this.angleLabel1.Size = new System.Drawing.Size(146, 24);
            this.angleLabel1.TabIndex = 1;
            this.angleLabel1.Text = "Введите первый угол";
            this.angleLabel1.Visible = false;
            // 
            // angleBar1
            // 
            this.angleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angleBar1.Location = new System.Drawing.Point(3, 3);
            this.angleBar1.Name = "angleBar1";
            this.angleBar1.Size = new System.Drawing.Size(146, 17);
            this.angleBar1.TabIndex = 2;
            this.angleBar1.Visible = false;
            this.angleBar1.Scroll += new System.EventHandler(this.AngleBar1_Scroll);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.angleLabel2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.angleBar2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(319, 56);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(152, 47);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // angleLabel2
            // 
            this.angleLabel2.AutoSize = true;
            this.angleLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angleLabel2.Location = new System.Drawing.Point(3, 23);
            this.angleLabel2.Name = "angleLabel2";
            this.angleLabel2.Size = new System.Drawing.Size(146, 24);
            this.angleLabel2.TabIndex = 1;
            this.angleLabel2.Text = "Введите второй угол";
            this.angleLabel2.Visible = false;
            // 
            // angleBar2
            // 
            this.angleBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angleBar2.Location = new System.Drawing.Point(3, 3);
            this.angleBar2.Name = "angleBar2";
            this.angleBar2.Size = new System.Drawing.Size(146, 17);
            this.angleBar2.TabIndex = 2;
            this.angleBar2.Visible = false;
            this.angleBar2.Scroll += new System.EventHandler(this.AngleBar2_Scroll);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(635, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 47);
            this.button7.TabIndex = 9;
            this.button7.Text = "Рисовать!";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.trackBar4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(477, 56);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(152, 47);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // trackBar4
            // 
            this.trackBar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar4.Location = new System.Drawing.Point(3, 3);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(146, 17);
            this.trackBar4.TabIndex = 0;
            this.trackBar4.Visible = false;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 332);
            this.panel1.TabIndex = 11;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecurBar)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleBar2)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button koch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label recLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label angleLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label angleLabel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TrackBar RecurBar;
        private System.Windows.Forms.TrackBar angleBar1;
        private System.Windows.Forms.TrackBar angleBar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

