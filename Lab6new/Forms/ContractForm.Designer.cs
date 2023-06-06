namespace Lab6new.Forms
{
    partial class ContractForm
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
            contractTable = new DataGridView();
            sortBox = new GroupBox();
            nullSortRadio = new RadioButton();
            costRadio = new RadioButton();
            endDateRadio = new RadioButton();
            startDateRadio = new RadioButton();
            typeSortBox = new GroupBox();
            descendingRadio = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            localityFilter = new ComboBox();
            searchButton = new Button();
            showCardButton = new Button();
            orderOrgFilter = new TextBox();
            label1 = new Label();
            performOrgFilter = new TextBox();
            label3 = new Label();
            addButton = new Button();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)contractTable).BeginInit();
            sortBox.SuspendLayout();
            typeSortBox.SuspendLayout();
            SuspendLayout();
            // 
            // contractTable
            // 
            contractTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            contractTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contractTable.Location = new Point(12, 174);
            contractTable.Name = "contractTable";
            contractTable.RowHeadersWidth = 51;
            contractTable.RowTemplate.Height = 29;
            contractTable.Size = new Size(776, 221);
            contractTable.TabIndex = 4;
            // 
            // sortBox
            // 
            sortBox.Controls.Add(nullSortRadio);
            sortBox.Controls.Add(costRadio);
            sortBox.Controls.Add(endDateRadio);
            sortBox.Controls.Add(startDateRadio);
            sortBox.Location = new Point(12, 111);
            sortBox.Name = "sortBox";
            sortBox.Size = new Size(377, 57);
            sortBox.TabIndex = 14;
            sortBox.TabStop = false;
            sortBox.Text = "Сортировка";
            // 
            // nullSortRadio
            // 
            nullSortRadio.AutoSize = true;
            nullSortRadio.Checked = true;
            nullSortRadio.Location = new Point(290, 26);
            nullSortRadio.Name = "nullSortRadio";
            nullSortRadio.Size = new Size(55, 24);
            nullSortRadio.TabIndex = 2;
            nullSortRadio.TabStop = true;
            nullSortRadio.Text = "Нет";
            nullSortRadio.UseVisualStyleBackColor = true;
            // 
            // costRadio
            // 
            costRadio.AutoSize = true;
            costRadio.Location = new Point(224, 26);
            costRadio.Name = "costRadio";
            costRadio.Size = new Size(66, 24);
            costRadio.TabIndex = 1;
            costRadio.Text = "Цена";
            costRadio.UseVisualStyleBackColor = true;
            // 
            // endDateRadio
            // 
            endDateRadio.AutoSize = true;
            endDateRadio.Location = new Point(117, 25);
            endDateRadio.Name = "endDateRadio";
            endDateRadio.Size = new Size(103, 24);
            endDateRadio.TabIndex = 0;
            endDateRadio.Text = "Дата окон.";
            endDateRadio.UseVisualStyleBackColor = true;
            // 
            // startDateRadio
            // 
            startDateRadio.AutoSize = true;
            startDateRadio.Location = new Point(6, 25);
            startDateRadio.Name = "startDateRadio";
            startDateRadio.Size = new Size(99, 24);
            startDateRadio.TabIndex = 0;
            startDateRadio.Text = "Дата закл.";
            startDateRadio.UseVisualStyleBackColor = true;
            // 
            // typeSortBox
            // 
            typeSortBox.Controls.Add(descendingRadio);
            typeSortBox.Controls.Add(radioButton4);
            typeSortBox.Location = new Point(417, 111);
            typeSortBox.Name = "typeSortBox";
            typeSortBox.Size = new Size(243, 57);
            typeSortBox.TabIndex = 15;
            typeSortBox.TabStop = false;
            typeSortBox.Text = "Сортировка";
            // 
            // descendingRadio
            // 
            descendingRadio.AutoSize = true;
            descendingRadio.Location = new Point(131, 25);
            descendingRadio.Name = "descendingRadio";
            descendingRadio.Size = new Size(101, 24);
            descendingRadio.TabIndex = 0;
            descendingRadio.Text = "Убывание";
            descendingRadio.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(6, 25);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(119, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Возрастание";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 46);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 14;
            label2.Text = "Населеный пункт";
            // 
            // localityFilter
            // 
            localityFilter.FormattingEnabled = true;
            localityFilter.Location = new Point(475, 69);
            localityFilter.Name = "localityFilter";
            localityFilter.Size = new Size(185, 28);
            localityFilter.TabIndex = 13;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(694, 95);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 16;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // showCardButton
            // 
            showCardButton.Location = new Point(492, 409);
            showCardButton.Name = "showCardButton";
            showCardButton.Size = new Size(135, 29);
            showCardButton.TabIndex = 17;
            showCardButton.Text = "Показать";
            showCardButton.UseVisualStyleBackColor = true;
            showCardButton.Click += showCardButton_Click;
            // 
            // orderOrgFilter
            // 
            orderOrgFilter.Location = new Point(18, 69);
            orderOrgFilter.Name = "orderOrgFilter";
            orderOrgFilter.Size = new Size(185, 27);
            orderOrgFilter.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 43);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 18;
            label1.Text = "Организация заказчика";
            // 
            // performOrgFilter
            // 
            performOrgFilter.Location = new Point(225, 69);
            performOrgFilter.Name = "performOrgFilter";
            performOrgFilter.Size = new Size(185, 27);
            performOrgFilter.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 43);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 20;
            label3.Text = "Организация исполнителя";
            // 
            // addButton
            // 
            addButton.Location = new Point(315, 409);
            addButton.Name = "addButton";
            addButton.Size = new Size(135, 29);
            addButton.TabIndex = 22;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(140, 409);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(135, 29);
            exportButton.TabIndex = 23;
            exportButton.Text = "Экспортировать";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportButton);
            Controls.Add(addButton);
            Controls.Add(performOrgFilter);
            Controls.Add(label3);
            Controls.Add(orderOrgFilter);
            Controls.Add(label1);
            Controls.Add(showCardButton);
            Controls.Add(searchButton);
            Controls.Add(label2);
            Controls.Add(localityFilter);
            Controls.Add(typeSortBox);
            Controls.Add(sortBox);
            Controls.Add(contractTable);
            Name = "ContractForm";
            Text = "ContractForm";
            Activated += ContractForm_Activated;
            Load += ContractForm_Load;
            Controls.SetChildIndex(contractTable, 0);
            Controls.SetChildIndex(sortBox, 0);
            Controls.SetChildIndex(typeSortBox, 0);
            Controls.SetChildIndex(localityFilter, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(showCardButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(orderOrgFilter, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(performOrgFilter, 0);
            Controls.SetChildIndex(addButton, 0);
            Controls.SetChildIndex(exportButton, 0);
            ((System.ComponentModel.ISupportInitialize)contractTable).EndInit();
            sortBox.ResumeLayout(false);
            sortBox.PerformLayout();
            typeSortBox.ResumeLayout(false);
            typeSortBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView contractTable;
        private GroupBox sortBox;
        private RadioButton nullSortRadio;
        private RadioButton costRadio;
        private RadioButton endDateRadio;
        private RadioButton startDateRadio;
        private GroupBox typeSortBox;
        private RadioButton descendingRadio;
        private RadioButton radioButton4;
        private Label label2;
        private ComboBox localityFilter;
        private Button searchButton;
        private Button showCardButton;
        private TextBox orderOrgFilter;
        private Label label1;
        private TextBox performOrgFilter;
        private Label label3;
        private Button addButton;
        private Button exportButton;
    }
}