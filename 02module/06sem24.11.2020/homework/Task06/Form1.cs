using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Если честно, то я не понял, как сделать движение по спирали, поэтому подсмотрел формулу в интернете.
namespace Task06
{
    public partial class Form1 : Form
    {
        int x = 200;
        double a = 1;
        Bitmap bit;
        Graphics grap;
        Point p;
        Point center;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Visible = false;
            this.timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bit = new Bitmap(this.Width, this.Height);
            grap = Graphics.FromImage(bit);
            grap.Clear(Color.Transparent);
            p = new Point();
            center = new Point(this.Width / 2 - 35, this.Height / 2 - 70);
          
            p.X = (int)((a / (Math.PI * 2)) * x * Math.Cos(x))+center.X+15;
            p.Y = (int)((a / (Math.PI * 2)) * x * Math.Sin(x))+center.Y+20;
            if (p.Y > this.Height || p.Y < 0 || p.X > this.Width || p.X < 0)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("Спутник улетел :(");
                x = 200;
                return;
            }
            grap.FillEllipse(Brushes.Green, center.X, center.Y, 50, 50);
            grap.FillEllipse(Brushes.BlueViolet, this.p.X, p.Y, 10, 10);
            x++;
            

            pictureBox1.Image = bit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
