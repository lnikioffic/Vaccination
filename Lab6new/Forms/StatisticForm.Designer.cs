namespace Lab6new.Forms
{
    partial class StatisticForm
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
            statisticTable = new DataGridView();
            searchButton = new Button();
            startDate = new TextBox();
            endDate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)statisticTable).BeginInit();
            SuspendLayout();
            // 
            // statisticTable
            // 
            statisticTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            statisticTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statisticTable.Location = new Point(12, 134);
            statisticTable.Name = "statisticTable";
            statisticTable.RowHeadersWidth = 51;
            statisticTable.RowTemplate.Height = 29;
            statisticTable.Size = new Size(776, 221);
            statisticTable.TabIndex = 4;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(555, 67);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(233, 29);
            searchButton.TabIndex = 8;
            searchButton.Text = "Сформировать статистику";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // startDate
            // 
            startDate.Location = new Point(30, 67);
            startDate.Name = "startDate";
            startDate.Size = new Size(185, 27);
            startDate.TabIndex = 16;
            // 
            // endDate
            // 
            endDate.Location = new Point(315, 67);
            endDate.Name = "endDate";
            endDate.Size = new Size(185, 27);
            endDate.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 44);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 18;
            label2.Text = "Дата начала";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 19;
            label1.Text = "Дата конца";
            // 
            // exportButton
            // 
            exportButton.Location = new Point(315, 400);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(155, 29);
            exportButton.TabIndex = 20;
            exportButton.Text = "Экспортировать";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(searchButton);
            Controls.Add(statisticTable);
            Name = "StatisticForm";
            Text = "StatisticForm";
            Controls.SetChildIndex(statisticTable, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(startDate, 0);
            Controls.SetChildIndex(endDate, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(exportButton, 0);
            ((System.ComponentModel.ISupportInitialize)statisticTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView statisticTable;
        private Button searchButton;
        private TextBox startDate;
        private TextBox endDate;
        private Label label2;
        private Label label1;
        private Button exportButton;
    }
}