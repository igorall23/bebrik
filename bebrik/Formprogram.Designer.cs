namespace bebrik
{
    partial class Formprogram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttoncreatearray = new System.Windows.Forms.Button();
            this.GridMatrixView = new System.Windows.Forms.DataGridView();
            this.buttonsort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatrixView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество элементов в массиве";
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.Location = new System.Drawing.Point(524, 9);
            this.numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(88, 30);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // buttoncreatearray
            // 
            this.buttoncreatearray.BackColor = System.Drawing.Color.Orchid;
            this.buttoncreatearray.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoncreatearray.Location = new System.Drawing.Point(21, 48);
            this.buttoncreatearray.Margin = new System.Windows.Forms.Padding(4);
            this.buttoncreatearray.Name = "buttoncreatearray";
            this.buttoncreatearray.Size = new System.Drawing.Size(603, 32);
            this.buttoncreatearray.TabIndex = 2;
            this.buttoncreatearray.Text = "Сгенерировать случайный массив";
            this.buttoncreatearray.UseVisualStyleBackColor = false;
            this.buttoncreatearray.Click += new System.EventHandler(this.buttoncreatearray_Click);
            // 
            // GridMatrixView
            // 
            this.GridMatrixView.AllowUserToResizeColumns = false;
            this.GridMatrixView.AllowUserToResizeRows = false;
            this.GridMatrixView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.GridMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMatrixView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMatrixView.ColumnHeadersHeight = 29;
            this.GridMatrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridMatrixView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMatrixView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridMatrixView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridMatrixView.Location = new System.Drawing.Point(21, 87);
            this.GridMatrixView.Margin = new System.Windows.Forms.Padding(4);
            this.GridMatrixView.Name = "GridMatrixView";
            this.GridMatrixView.ReadOnly = true;
            this.GridMatrixView.RowHeadersVisible = false;
            this.GridMatrixView.RowHeadersWidth = 51;
            this.GridMatrixView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridMatrixView.Size = new System.Drawing.Size(603, 75);
            this.GridMatrixView.TabIndex = 8;
            this.GridMatrixView.TabStop = false;
            this.GridMatrixView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMatrixView_CellContentClick);
            // 
            // buttonsort
            // 
            this.buttonsort.BackColor = System.Drawing.Color.Orchid;
            this.buttonsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsort.Location = new System.Drawing.Point(21, 151);
            this.buttonsort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsort.Name = "buttonsort";
            this.buttonsort.Size = new System.Drawing.Size(603, 32);
            this.buttonsort.TabIndex = 9;
            this.buttonsort.Text = "Отсортировать массив";
            this.buttonsort.UseVisualStyleBackColor = false;
            this.buttonsort.Click += new System.EventHandler(this.buttonsort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bebrik.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(647, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Formprogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(762, 198);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonsort);
            this.Controls.Add(this.GridMatrixView);
            this.Controls.Add(this.buttoncreatearray);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formprogram";
            this.Text = "Гномья сортировка - Программа";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatrixView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button buttoncreatearray;
        private System.Windows.Forms.DataGridView GridMatrixView;
        private System.Windows.Forms.Button buttonsort;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}