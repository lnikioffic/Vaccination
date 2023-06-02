namespace Lab6new.Forms
{
    partial class AnimalCardForm
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
            dataTable = new TableLayoutPanel();
            SuspendLayout();
            // 
            // dataTable
            // 
            dataTable.AutoSize = true;
            dataTable.ColumnCount = 2;
            dataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            dataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            dataTable.Location = new Point(12, 12);
            dataTable.Name = "dataTable";
            dataTable.RowCount = 1;
            dataTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            dataTable.Size = new Size(522, 28);
            dataTable.TabIndex = 1;
            // 
            // AnimalCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataTable);
            Name = "AnimalCardForm";
            Text = "AnimalCardForm";
            Load += AnimalCardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel dataTable;
    }
}