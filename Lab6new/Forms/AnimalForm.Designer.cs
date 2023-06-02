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
            animalTable = new DataGridView();
            localityFilter = new ComboBox();
            searchButton = new Button();
            sexFilter = new GroupBox();
            maleCheckBox = new CheckBox();
            femaleCheckBox = new CheckBox();
            categoryFilter = new GroupBox();
            dogCheckBox = new CheckBox();
            catCheckBox = new CheckBox();
            showCardButton = new Button();
            label1 = new Label();
            label2 = new Label();
            sortBox = new GroupBox();
            nullSortRadio = new RadioButton();
            nameRadio = new RadioButton();
            localityRadio = new RadioButton();
            regNumberRadio = new RadioButton();
            typeSortBox = new GroupBox();
            descendingRadio = new RadioButton();
            radioButton4 = new RadioButton();
            registrationNumberFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)animalTable).BeginInit();
            sexFilter.SuspendLayout();
            categoryFilter.SuspendLayout();
            sortBox.SuspendLayout();
            typeSortBox.SuspendLayout();
            SuspendLayout();
            // 
            // animalTable
            // 
            animalTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            animalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            animalTable.Location = new Point(12, 173);
            animalTable.Name = "animalTable";
            animalTable.RowHeadersWidth = 51;
            animalTable.RowTemplate.Height = 29;
            animalTable.Size = new Size(776, 221);
            animalTable.TabIndex = 3;
            // 
            // localityFilter
            // 
            localityFilter.FormattingEnabled = true;
            localityFilter.Location = new Point(453, 82);
            localityFilter.Name = "localityFilter";
            localityFilter.Size = new Size(185, 28);
            localityFilter.TabIndex = 4;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(678, 83);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 7;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // sexFilter
            // 
            sexFilter.Controls.Add(maleCheckBox);
            sexFilter.Controls.Add(femaleCheckBox);
            sexFilter.Location = new Point(12, 34);
            sexFilter.Name = "sexFilter";
            sexFilter.Size = new Size(90, 79);
            sexFilter.TabIndex = 8;
            sexFilter.TabStop = false;
            sexFilter.Text = "Пол";
            // 
            // maleCheckBox
            // 
            maleCheckBox.AutoSize = true;
            maleCheckBox.Checked = true;
            maleCheckBox.CheckState = CheckState.Checked;
            maleCheckBox.Location = new Point(6, 26);
            maleCheckBox.Name = "maleCheckBox";
            maleCheckBox.Size = new Size(76, 24);
            maleCheckBox.TabIndex = 11;
            maleCheckBox.Text = "Самец";
            maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckBox
            // 
            femaleCheckBox.AutoSize = true;
            femaleCheckBox.Checked = true;
            femaleCheckBox.CheckState = CheckState.Checked;
            femaleCheckBox.Location = new Point(6, 49);
            femaleCheckBox.Name = "femaleCheckBox";
            femaleCheckBox.Size = new Size(74, 24);
            femaleCheckBox.TabIndex = 12;
            femaleCheckBox.Text = "Самка";
            femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryFilter
            // 
            categoryFilter.Controls.Add(dogCheckBox);
            categoryFilter.Controls.Add(catCheckBox);
            categoryFilter.Location = new Point(108, 34);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(109, 79);
            categoryFilter.TabIndex = 9;
            categoryFilter.TabStop = false;
            categoryFilter.Text = "Животное";
            // 
            // dogCheckBox
            // 
            dogCheckBox.AutoSize = true;
            dogCheckBox.Checked = true;
            dogCheckBox.CheckState = CheckState.Checked;
            dogCheckBox.Location = new Point(6, 26);
            dogCheckBox.Name = "dogCheckBox";
            dogCheckBox.Size = new Size(81, 24);
            dogCheckBox.TabIndex = 13;
            dogCheckBox.Text = "Собака";
            dogCheckBox.UseVisualStyleBackColor = true;
            // 
            // catCheckBox
            // 
            catCheckBox.AutoSize = true;
            catCheckBox.Checked = true;
            catCheckBox.CheckState = CheckState.Checked;
            catCheckBox.Location = new Point(6, 49);
            catCheckBox.Name = "catCheckBox";
            catCheckBox.Size = new Size(76, 24);
            catCheckBox.TabIndex = 14;
            catCheckBox.Text = "Кошка";
            catCheckBox.UseVisualStyleBackColor = true;
            // 
            // showCardButton
            // 
            showCardButton.Location = new Point(330, 409);
            showCardButton.Name = "showCardButton";
            showCardButton.Size = new Size(135, 29);
            showCardButton.TabIndex = 10;
            showCardButton.Text = "Показать";
            showCardButton.UseVisualStyleBackColor = true;
            showCardButton.Click += showCardButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 59);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 11;
            label1.Text = "Регистрационный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 59);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 12;
            label2.Text = "Населеный пункт";
            // 
            // sortBox
            // 
            sortBox.Controls.Add(nullSortRadio);
            sortBox.Controls.Add(nameRadio);
            sortBox.Controls.Add(localityRadio);
            sortBox.Controls.Add(regNumberRadio);
            sortBox.Location = new Point(12, 113);
            sortBox.Name = "sortBox";
            sortBox.Size = new Size(377, 57);
            sortBox.TabIndex = 13;
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
            // nameRadio
            // 
            nameRadio.AutoSize = true;
            nameRadio.Location = new Point(224, 26);
            nameRadio.Name = "nameRadio";
            nameRadio.Size = new Size(60, 24);
            nameRadio.TabIndex = 1;
            nameRadio.Text = "Имя";
            nameRadio.UseVisualStyleBackColor = true;
            // 
            // localityRadio
            // 
            localityRadio.AutoSize = true;
            localityRadio.Location = new Point(117, 25);
            localityRadio.Name = "localityRadio";
            localityRadio.Size = new Size(101, 24);
            localityRadio.TabIndex = 0;
            localityRadio.Text = "Нас. пункт";
            localityRadio.UseVisualStyleBackColor = true;
            // 
            // regNumberRadio
            // 
            regNumberRadio.AutoSize = true;
            regNumberRadio.Location = new Point(6, 25);
            regNumberRadio.Name = "regNumberRadio";
            regNumberRadio.Size = new Size(105, 24);
            regNumberRadio.TabIndex = 0;
            regNumberRadio.Text = "Рег. номер";
            regNumberRadio.UseVisualStyleBackColor = true;
            // 
            // typeSortBox
            // 
            typeSortBox.Controls.Add(descendingRadio);
            typeSortBox.Controls.Add(radioButton4);
            typeSortBox.Location = new Point(411, 113);
            typeSortBox.Name = "typeSortBox";
            typeSortBox.Size = new Size(243, 57);
            typeSortBox.TabIndex = 14;
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
            // registrationNumberFilter
            // 
            registrationNumberFilter.Location = new Point(236, 85);
            registrationNumberFilter.Name = "registrationNumberFilter";
            registrationNumberFilter.Size = new Size(185, 27);
            registrationNumberFilter.TabIndex = 15;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registrationNumberFilter);
            Controls.Add(typeSortBox);
            Controls.Add(sortBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(showCardButton);
            Controls.Add(categoryFilter);
            Controls.Add(sexFilter);
            Controls.Add(searchButton);
            Controls.Add(localityFilter);
            Controls.Add(animalTable);
            Name = "AnimalForm";
            Text = "";
            Load += AnimalForm_Load;
            Controls.SetChildIndex(animalTable, 0);
            Controls.SetChildIndex(localityFilter, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(sexFilter, 0);
            Controls.SetChildIndex(categoryFilter, 0);
            Controls.SetChildIndex(showCardButton, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(sortBox, 0);
            Controls.SetChildIndex(typeSortBox, 0);
            Controls.SetChildIndex(registrationNumberFilter, 0);
            ((System.ComponentModel.ISupportInitialize)animalTable).EndInit();
            sexFilter.ResumeLayout(false);
            sexFilter.PerformLayout();
            categoryFilter.ResumeLayout(false);
            categoryFilter.PerformLayout();
            sortBox.ResumeLayout(false);
            sortBox.PerformLayout();
            typeSortBox.ResumeLayout(false);
            typeSortBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView animalTable;
        private ComboBox localityFilter;
        private Button searchButton;
        private GroupBox sexFilter;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private GroupBox categoryFilter;
        private Button showCardButton;
        private CheckBox maleCheckBox;
        private CheckBox femaleCheckBox;
        private CheckBox dogCheckBox;
        private CheckBox catCheckBox;
        private Label label1;
        private Label label2;
        private GroupBox sortBox;
        private RadioButton localityRadio;
        private RadioButton regNumberRadio;
        private RadioButton nullSortRadio;
        private RadioButton nameRadio;
        private GroupBox typeSortBox;
        private RadioButton descendingRadio;
        private RadioButton radioButton4;
        private TextBox registrationNumberFilter;
    }
}