using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пара_04._05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text += e.KeyChar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(label1.Text);
                label1.Text = "";
            }

            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            //if (e.KeyChar == 'q')
            //{
            //    listBox1.Items.Add(label1.Text);
            //    label1.Text = "";
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(Convert.ToString(MousePosition.X - Location.X-8) + "; " + Convert.ToString(MousePosition.Y-Location.Y-8));


        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button1.Left = rnd.Next(0, 26);
            button1.Top = rnd.Next(0, 80);
         
        }
    }
}
