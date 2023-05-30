namespace Lab6new.Forms
{
    partial class AnimalForm
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
            dataGridView1 = new DataGridView();
            localityFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 221);
            dataGridView1.TabIndex = 3;
            // 
            // localityFilter
            // 
            localityFilter.FormattingEnabled = true;
            localityFilter.Location = new Point(18, 54);
            localityFilter.Name = "localityFilter";
            localityFilter.Size = new Size(151, 28);
            localityFilter.TabIndex = 4;
            localityFilter.TextChanged += localityFilter_TextChanged;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(localityFilter);
            Controls.Add(dataGridView1);
            Name = "AnimalForm";
            Text = "AnimalForm";
            Load += AnimalForm_Load;
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(localityFilter, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox localityFilter;
    }
}