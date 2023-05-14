namespace SimplexMethod
{
    partial class maximax
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maximax));
            this.nOfProjectsTextBox = new System.Windows.Forms.TextBox();
            this.nOfConditionsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.constraintsGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.constraintsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nOfProjectsTextBox
            // 
            this.nOfProjectsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nOfProjectsTextBox.Location = new System.Drawing.Point(730, 66);
            this.nOfProjectsTextBox.Name = "nOfProjectsTextBox";
            this.nOfProjectsTextBox.Size = new System.Drawing.Size(34, 30);
            this.nOfProjectsTextBox.TabIndex = 0;
            // 
            // nOfConditionsTextBox
            // 
            this.nOfConditionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nOfConditionsTextBox.Location = new System.Drawing.Point(988, 66);
            this.nOfConditionsTextBox.Name = "nOfConditionsTextBox";
            this.nOfConditionsTextBox.Size = new System.Drawing.Size(34, 30);
            this.nOfConditionsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(601, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "N. of projects";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.okBtn.Location = new System.Drawing.Point(1330, 66);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(69, 36);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // constraintsGridView
            // 
            this.constraintsGridView.BackgroundColor = System.Drawing.Color.White;
            this.constraintsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.constraintsGridView.Location = new System.Drawing.Point(621, 110);
            this.constraintsGridView.Name = "constraintsGridView";
            this.constraintsGridView.RowHeadersWidth = 51;
            this.constraintsGridView.Size = new System.Drawing.Size(778, 246);
            this.constraintsGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(831, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "N. of conditions";
            // 
            // calculateResult
            // 
            this.calculateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateResult.Location = new System.Drawing.Point(1256, 378);
            this.calculateResult.Name = "calculateResult";
            this.calculateResult.Size = new System.Drawing.Size(143, 62);
            this.calculateResult.TabIndex = 6;
            this.calculateResult.Text = "Calculate";
            this.calculateResult.UseVisualStyleBackColor = true;
            this.calculateResult.Click += new System.EventHandler(this.calculateResult_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(668, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(111)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(936, 707);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(778, 246);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1324, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maximax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimplexMethod.Properties.Resources.page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1746, 760);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateResult);
            this.Controls.Add(this.constraintsGridView);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nOfConditionsTextBox);
            this.Controls.Add(this.nOfProjectsTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "maximax";
            this.Text = "MaxiMax";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.constraintsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nOfProjectsTextBox;
        private System.Windows.Forms.TextBox nOfConditionsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.DataGridView constraintsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

