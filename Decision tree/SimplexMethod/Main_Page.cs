using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexMethod
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maximax obj = new maximax();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maximin obj = new maximin();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MiniMaxRegret obj = new MiniMaxRegret();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMV obj = new EMV();
            obj.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0); this.Size = new Size(width, height);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EquallyLikely E1 = new EquallyLikely();
            E1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            opporyunity_loss o1 = new opporyunity_loss();
            o1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
