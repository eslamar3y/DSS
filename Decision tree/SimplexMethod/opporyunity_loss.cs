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
    public partial class opporyunity_loss : Form
    {
        public opporyunity_loss()
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

        void fillResultGrid1()
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
                    dataGridView1.Columns[i].Name = "Max";
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
                    dataGridView1.Rows[i + 1].SetValues("Probability: ");
                }
            }


        }


        int minimaxregr = 0;
        int minimaxregr2 = 0;

        private void calculateResult_Click(object sender, EventArgs e)
        {
            fillResultGrid1();
            int imax;

            for (int z = 1; z <= constraintsCount; z++)
            {
                imax = 0;

                for (int x = 0; x < variablesCount; x++)
                {
                    if (Convert.ToInt32(constraintsGridView.Rows[x].Cells[z].Value) > imax)
                    {
                        imax = Convert.ToInt32(constraintsGridView.Rows[x].Cells[z].Value);
                    }

                }
                for (int x = 0; x < variablesCount; x++)
                {
                    if (imax > 0)
                    {
                        dataGridView1.Rows[x].Cells[z].Value =
                            (imax - Convert.ToInt32(constraintsGridView.Rows[x].Cells[z].Value)).ToString();

                    }


                }
            }

            calcregret();
        }
        void mimr()
        {
            minimaxregr = Convert.ToInt32(dataGridView1.Rows[0].Cells[constraintsCount + 1].Value);
            for (int z = 0; z < variablesCount; z++)
            {

                if (Convert.ToInt32(dataGridView1.Rows[z].Cells[constraintsCount + 1].Value) < minimaxregr)
                {
                    minimaxregr = Convert.ToInt32(dataGridView1.Rows[z].Cells[constraintsCount + 1].Value);
                }


            }
        }
        void calcregret()
        {
            double maximax = 0;

            for (int i = 0; i < constraintsCount; i++)
            {

                double max_row = 0;
                for (int j = 1; j <= variablesCount; j++)
                {
                    double valu = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    if (valu > max_row)
                    {
                        max_row = valu;
                    }
                    if (j == variablesCount)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = max_row.ToString();
                    }

                }
                max_row = 0;

            }
        }


        void fillResultGrid2()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.ColumnCount = variablesCount + 2;
            dataGridView2.RowHeadersVisible = true;
            for (int i = 0; i < variablesCount + 2; i++)
            {
                dataGridView2.Columns[i].Width = 130;
                dataGridView2.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i == 0)
                {

                    dataGridView2.Columns[i].Name = "N. Project:";
                }
                else if (i <= variablesCount)
                {
                    dataGridView2.Columns[i].Name = "Condition: " + (i).ToString();
                }
                else if (i == variablesCount + 1)
                {
                    dataGridView2.Columns[i].Name = "Max";
                }


            }

            for (int i = 0; i < constraintsCount; i++)
            {
                string[] row = new string[variablesCount + 2];
                dataGridView2.Rows.Add(row);
                dataGridView2.Rows[i].Height = 20;
                if (i < constraintsCount)
                {
                    dataGridView2.Rows[i].SetValues("Project: " + (i + 1).ToString());
                }
            }

        }

        void mimr2()
        {
            minimaxregr2 = Convert.ToInt32(dataGridView2.Rows[0].Cells[constraintsCount + 1].Value);
            for (int z = 0; z > variablesCount; z++)
            {

                if (Convert.ToInt32(dataGridView2.Rows[z].Cells[constraintsCount + 1].Value) > minimaxregr)
                {
                    minimaxregr2 = Convert.ToInt32(dataGridView2.Rows[z].Cells[constraintsCount + 1].Value);
                }


            }
        }
        void calcregret2()
        {
            double maximax = 0;

            double valu = 0;

            for (int i = 0; i < variablesCount; i++)
            {
                valu = 0;
                double max_row = 0;

                for (int j = 1; j <= constraintsCount; j++)
                {
                    valu += Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);

                }
                dataGridView2.Rows[i].Cells[constraintsCount + 1].Value = valu.ToString();



                max_row = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillResultGrid2();
            int imax2;

            for (int z = 1; z <= constraintsCount; z++)
            {
                imax2 = 0;


                for (int x = 0; x < variablesCount; x++)
                {


                    dataGridView2.Rows[x].Cells[z].Value =
                        (Convert.ToDouble(dataGridView1.Rows[variablesCount].Cells[z].Value) * Convert.ToDouble(dataGridView1.Rows[x].Cells[z].Value)).ToString();

                }
            }

            calcregret2();

            mimr2();

            label4.Text = "minimax Result value is: ";
            label6.Text = minimaxregr2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Page f1 = new Main_Page();
            f1.Show();
            this.Hide();
        }

        private void opporyunity_loss_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0); this.Size = new Size(width, height);
        }
    }
}
