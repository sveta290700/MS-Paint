using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_Paint_ver_1
{
    public partial class Form1 : Form
    {
        Color color;
        Point location = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = pictureBox1.Size.Width;
        }
        protected void Form1_Disposed(object sender, EventArgs e)
        {
           
        }

        protected void Form1_Shown(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_red;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_green;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_blue;
                else pictureBox1.Image = Properties.Resources.apple_black;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
            else
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_red_filled;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_green_filled;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_blue_filled;
                else pictureBox1.Image = Properties.Resources.apple_black_filled;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.star_red;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.star_green;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.star_blue;
                else pictureBox1.Image = Properties.Resources.star_black;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
            else
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.star_red_filled;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.star_green_filled;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.star_blue_filled;
                else pictureBox1.Image = Properties.Resources.star_black_filled;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                location = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            location = Point.Empty;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            color = pictureBox2.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            color = pictureBox3.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            color = pictureBox4.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.heart_red;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.heart_green;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.heart_blue;
                else pictureBox1.Image = Properties.Resources.heart_black;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
            else
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.heart_red_filled;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.heart_green_filled;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.heart_blue_filled;
                else pictureBox1.Image = Properties.Resources.heart_black_filled;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (location != Point.Empty)
            {
                Point newlocation = this.pictureBox1.Location;
                newlocation.X += e.X - location.X;
                newlocation.Y += e.Y - location.Y;
                this.pictureBox1.Location = newlocation;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(trackBar1.Value, trackBar1.Value);
            textBox1.Text = Convert.ToString(pictureBox1.Location.X + trackBar1.Value / 10);
            textBox2.Text = Convert.ToString(pictureBox1.Location.Y + trackBar1.Value / 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image image;
            image = pictureBox1.Image;
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkBox1.Checked = false;
            pictureBox1.Image = null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.star_red;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.star_green;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.star_blue;
                else pictureBox1.Image = Properties.Resources.star_black;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
            else
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.star_red_filled;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.star_green_filled;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.star_blue_filled;
                else pictureBox1.Image = Properties.Resources.star_black_filled;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_red;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_green;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_blue;
                else pictureBox1.Image = Properties.Resources.apple_black;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
            else
            {
                if (color == pictureBox2.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_red_filled;
                else if (color == pictureBox3.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_green_filled;
                else if (color == pictureBox4.BackColor)
                    pictureBox1.Image = Properties.Resources.apple_blue_filled;
                else pictureBox1.Image = Properties.Resources.apple_black_filled;
                textBox1.Text = Convert.ToString(pictureBox1.Location.X);
                textBox2.Text = Convert.ToString(pictureBox1.Location.Y);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //read image
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            //get image dimension
            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap rbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    Color p = bmp.GetPixel(x, y);

                    //extract A value from p
                    int a = p.A;

                    //set red image pixel
                    rbmp.SetPixel(x, y, Color.FromArgb(a, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text)));

                }
            }
            pictureBox1.Image = rbmp;
        }

    }
}
