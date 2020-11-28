using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task04
{
    public partial class Form1 : Form
    {
        static string[] str = { "один", "два", "три", "четыре", "пять", "шесть", "семь", };
        string[] newStr = str;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            listBox1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            newStr = str;
            listBox1.Items.AddRange(newStr);
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n==-1)
            {
                MessageBox.Show("Спасиок пуст или\nнет выделенного элимента");
                return;
            }
            listBox1.Items.RemoveAt(n);
        }
    }
}
