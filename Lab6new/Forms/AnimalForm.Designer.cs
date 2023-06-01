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
            registrationNumberFilter = new ComboBox();
            chipNumberFilter = new ComboBox();
            searchButton = new Button();
            sexFilter = new GroupBox();
            maleCheckBox = new CheckBox();
            femaleCheckBox = new CheckBox();
            categoryFilter = new GroupBox();
            dogCheckBox = new CheckBox();
            catCheckBox = new CheckBox();
            showCardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)animalTable).BeginInit();
            sexFilter.SuspendLayout();
            categoryFilter.SuspendLayout();
            SuspendLayout();
            // 
            // animalTable
            // 
            animalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            animalTable.Location = new Point(12, 119);
            animalTable.Name = "animalTable";
            animalTable.RowHeadersWidth = 51;
            animalTable.RowTemplate.Height = 29;
            animalTable.Size = new Size(776, 221);
            animalTable.TabIndex = 3;
            // 
            // localityFilter
            // 
            localityFilter.FormattingEnabled = true;
            localityFilter.Location = new Point(537, 63);
            localityFilter.Name = "localityFilter";
            localityFilter.Size = new Size(151, 28);
            localityFilter.TabIndex = 4;
            // 
            // registrationNumberFilter
            // 
            registrationNumberFilter.FormattingEnabled = true;
            registrationNumberFilter.Location = new Point(380, 63);
            registrationNumberFilter.Name = "registrationNumberFilter";
            registrationNumberFilter.Size = new Size(151, 28);
            registrationNumberFilter.TabIndex = 5;
            // 
            // chipNumberFilter
            // 
            chipNumberFilter.FormattingEnabled = true;
            chipNumberFilter.Location = new Point(223, 63);
            chipNumberFilter.Name = "chipNumberFilter";
            chipNumberFilter.Size = new Size(151, 28);
            chipNumberFilter.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(694, 62);
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
            catCheckBox.Location = new Point(6, 49);
            catCheckBox.Name = "catCheckBox";
            catCheckBox.Size = new Size(76, 24);
            catCheckBox.TabIndex = 14;
            catCheckBox.Text = "Кошка";
            catCheckBox.UseVisualStyleBackColor = true;
            // 
            // showCardButton
            // 
            showCardButton.Location = new Point(309, 379);
            showCardButton.Name = "showCardButton";
            showCardButton.Size = new Size(135, 29);
            showCardButton.TabIndex = 10;
            showCardButton.Text = "Показать";
            showCardButton.UseVisualStyleBackColor = true;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showCardButton);
            Controls.Add(categoryFilter);
            Controls.Add(sexFilter);
            Controls.Add(searchButton);
            Controls.Add(chipNumberFilter);
            Controls.Add(registrationNumberFilter);
            Controls.Add(localityFilter);
            Controls.Add(animalTable);
            Name = "AnimalForm";
            Text = "AnimalForm";
            Load += AnimalForm_Load;
            Controls.SetChildIndex(animalTable, 0);
            Controls.SetChildIndex(localityFilter, 0);
            Controls.SetChildIndex(registrationNumberFilter, 0);
            Controls.SetChildIndex(chipNumberFilter, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(sexFilter, 0);
            Controls.SetChildIndex(categoryFilter, 0);
            Controls.SetChildIndex(showCardButton, 0);
            ((System.ComponentModel.ISupportInitialize)animalTable).EndInit();
            sexFilter.ResumeLayout(false);
            sexFilter.PerformLayout();
            categoryFilter.ResumeLayout(false);
            categoryFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView animalTable;
        private ComboBox localityFilter;
        private ComboBox registrationNumberFilter;
        private ComboBox chipNumberFilter;
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
    }
}