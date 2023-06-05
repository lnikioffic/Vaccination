namespace Lab6new.Forms
{
    partial class ContractCardForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            orderOrgCombobox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            performOrgComboBox = new ComboBox();
            numbTextBox = new TextBox();
            label5 = new Label();
            startDate = new TextBox();
            endDate = new TextBox();
            localityCombobox = new ComboBox();
            costTextBox = new TextBox();
            label6 = new Label();
            contractAddButton = new Button();
            addLocalityButton = new Button();
            label7 = new Label();
            label8 = new Label();
            localitiesTable = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            deleteButton= new Button();
            updateButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Заказчик:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Исполнитель:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 101);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Дата заключения:*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 137);
            label4.Name = "label4";
            label4.Size = new Size(197, 20);
            label4.TabIndex = 3;
            label4.Text = "Дата окончания действия:*";
            // 
            // orderOrgCombobox
            // 
            orderOrgCombobox.FormattingEnabled = true;
            orderOrgCombobox.Location = new Point(208, 36);
            orderOrgCombobox.Name = "orderOrgCombobox";
            orderOrgCombobox.Size = new Size(214, 28);
            orderOrgCombobox.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2352943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7647057F));
            tableLayoutPanel1.Controls.Add(performOrgComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(numbTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(orderOrgCombobox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(startDate, 1, 3);
            tableLayoutPanel1.Controls.Add(endDate, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.25373F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.74627F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(425, 238);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // performOrgComboBox
            // 
            performOrgComboBox.FormattingEnabled = true;
            performOrgComboBox.Location = new Point(208, 70);
            performOrgComboBox.Name = "performOrgComboBox";
            performOrgComboBox.Size = new Size(214, 28);
            performOrgComboBox.TabIndex = 18;
            // 
            // numbTextBox
            // 
            numbTextBox.Location = new Point(208, 3);
            numbTextBox.Name = "numbTextBox";
            numbTextBox.Size = new Size(214, 27);
            numbTextBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 19;
            label5.Text = "Номер:";
            // 
            // startDate
            // 
            startDate.Location = new Point(208, 104);
            startDate.Name = "startDate";
            startDate.Size = new Size(214, 27);
            startDate.TabIndex = 20;
            // 
            // endDate
            // 
            endDate.Location = new Point(208, 140);
            endDate.Name = "endDate";
            endDate.Size = new Size(214, 27);
            endDate.TabIndex = 21;
            // 
            // localityCombobox
            // 
            localityCombobox.FormattingEnabled = true;
            localityCombobox.Location = new Point(452, 260);
            localityCombobox.Name = "localityCombobox";
            localityCombobox.Size = new Size(197, 28);
            localityCombobox.TabIndex = 18;
            // 
            // costTextBox
            // 
            costTextBox.Location = new Point(658, 261);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(87, 27);
            costTextBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 237);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 20;
            label6.Text = "Нас. пункт";
            // 
            // contractAddButton
            // 
            contractAddButton.Location = new Point(301, 382);
            contractAddButton.Name = "contractAddButton";
            contractAddButton.Size = new Size(203, 29);
            contractAddButton.TabIndex = 21;
            contractAddButton.Text = "Добавить контракт";
            contractAddButton.UseVisualStyleBackColor = true;
            contractAddButton.Click += contractAddButton_Click;
            // 
            // addLocalityButton
            // 
            addLocalityButton.Location = new Point(513, 305);
            addLocalityButton.Name = "addLocalityButton";
            addLocalityButton.Size = new Size(190, 29);
            addLocalityButton.TabIndex = 22;
            addLocalityButton.Text = "Добавить нас. пункт";
            addLocalityButton.UseVisualStyleBackColor = true;
            addLocalityButton.Click += addLocalityButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(658, 237);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 23;
            label7.Text = "Цена";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 305);
            label8.Name = "label8";
            label8.Size = new Size(283, 20);
            label8.TabIndex = 25;
            label8.Text = "* Дата должна быть формата дд.мм.гггг";
            // 
            // localitiesTable
            // 
            localitiesTable.AutoSize = true;
            localitiesTable.ColumnCount = 3;
            localitiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.2599258F));
            localitiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.74007F));
            localitiesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            localitiesTable.Location = new Point(458, 53);
            localitiesTable.Name = "localitiesTable";
            localitiesTable.RowCount = 1;
            localitiesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            localitiesTable.Size = new Size(287, 24);
            localitiesTable.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(458, 30);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 27;
            label9.Text = "Нас. пункт";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(593, 30);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 28;
            label10.Text = "Цена";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(175, 382);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(203, 29);
            deleteButton.TabIndex = 22;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(425, 382);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(203, 29);
            updateButton.TabIndex = 22;
            updateButton.Text = "Изменить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // ContractAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(localitiesTable);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(addLocalityButton);
            Controls.Add(contractAddButton);
            Controls.Add(label6);
            Controls.Add(costTextBox);
            Controls.Add(localityCombobox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Name = "ContractAddForm";
            Text = "ContractCardForm";
            Load += ContractCardForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox orderOrgCombobox;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox performOrgComboBox;
        private Label label5;
        private TextBox numbTextBox;
        private TextBox startDate;
        private TextBox endDate;
        private ComboBox localityCombobox;
        private TextBox costTextBox;
        private Label label6;
        private Button contractAddButton;
        private Button addLocalityButton;
        private Label label7;
        private Label label8;
        private TableLayoutPanel localitiesTable;
        private Label label9;
        private Label label10;
        private Button deleteButton;
        private Button updateButton;
    }
}