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
    public partial class maximin : System.Windows.Forms.Form
    {
        public maximin()
        {
            InitializeComponent();
        }

        int constraintsCount = 0;
        int variablesCount = 0;

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                constraintsCount = Convert.ToInt32(nOfProjectsTextBox.Text);
                variablesCount = Convert.ToInt32(nOfConditionsTextBox.Text);
                fillConstraintsGrid();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void fillConstraintsGrid()
        {
            constraintsGridView.Rows.Clear();
            constraintsGridView.ColumnCount = variablesCount + 1;
            constraintsGridView.RowHeadersVisible = false;
            for (int i = 0; i < variablesCount + 1; i++)
            {
                constraintsGridView.Columns[i].Width = 130;
                constraintsGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i == 0)
                {

                    constraintsGridView.Columns[i].Name = "N. Project:";
                }
                else if (i <= variablesCount)
                {
                    constraintsGridView.Columns[i].Name = "Condition: " + (i).ToString();
                }

            }

            for (int i = 0; i < constraintsCount; i++)
            {
                string[] row = new string[variablesCount + 2];
                constraintsGridView.Rows.Add(row);
                constraintsGridView.Rows[i].Height = 20;
                if (i < constraintsCount)
                {
                    constraintsGridView.Rows[i].SetValues("Project: " + (i + 1).ToString());
                }
            }
        }
        void fillResultGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = variablesCount + 2;
            dataGridView1.RowHeadersVisible = false;
            for (int i = 0; i < variablesCount + 2; i++)
            {
                dataGridView1.Columns[i].Width = 130;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i == 0)
                {

                    dataGridView1.Columns[i].Name = "N. Project:";
                }
                else if (i <= variablesCount)
                {
                    dataGridView1.Columns[i].Name = "Condition: " + (i).ToString();
                }
                else if (i == variablesCount + 1)
                {
                    dataGridView1.Columns[i].Name = "Min";
                }


            }

            for (int i = 0; i < constraintsCount; i++)
            {
                string[] row = new string[variablesCount + 2];
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[i].Height = 20;
                if (i < constraintsCount)
                {
                    dataGridView1.Rows[i].SetValues("Project: " + (i + 1).ToString());
                }
            }
        }
        private void calculateResult_Click(object sender, EventArgs e)
        {
            fillResultGrid();

            double maximin = 0;
            for (int i = 0; i < constraintsCount; i++)
            {

                double min_row = 99999999;
                for (int j = 1; j <= variablesCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = constraintsGridView.Rows[i].Cells[j].Value;
                    double valu = Convert.ToDouble(constraintsGridView.Rows[i].Cells[j].Value);
                    label5.Text = valu.ToString();
                    if (valu < min_row)
                    {
                        min_row = valu;
                    }
                    if (j == variablesCount)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = min_row.ToString();
                    }

                }
                min_row = 99999999;

            }
            for (int i = 0; i < constraintsCount; i++)
            {
                double maxvalu = Convert.ToDouble(dataGridView1.Rows[i].Cells[variablesCount + 1].Value);

                if (maxvalu > maximin)
                {
                    maximin = maxvalu;
                }
            }
            label3.Text = "MaxiMin Result value is: ";
            label5.Text = maximin.ToString();



            //row j is the index of row and starts with 0
            //cell i is the number of cell and starts with 1
            //double valu = Convert.ToDouble(constraintsGridView.Rows[j].Cells[i].Value);


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nOfProjectsTextBox.Clear();
            nOfConditionsTextBox.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0); this.Size = new Size(width, height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Page f1 = new Main_Page();
            f1.Show();
            this.Hide();
        }
    }
}
