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
            animalPhoto = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            regNumb = new TextBox();
            category = new ComboBox();
            sex = new ComboBox();
            birthYear = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            specialSigns = new TextBox();
            locality = new TextBox();
            name = new TextBox();
            chipNumb = new TextBox();
            actType = new TextBox();
            actStartDate = new TextBox();
            actEndDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)animalPhoto).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // animalPhoto
            // 
            animalPhoto.Location = new Point(575, 12);
            animalPhoto.Name = "animalPhoto";
            animalPhoto.Size = new Size(200, 183);
            animalPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            animalPhoto.TabIndex = 1;
            animalPhoto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 2;
            label1.Text = "Регистрационный номер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Животное:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Пол:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 5;
            label4.Text = "Год рождения:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 195);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 6;
            label5.Text = "Населеный пункт:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(575, 205);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 7;
            label6.Text = "Последняя вакцина:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 230);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 8;
            label7.Text = "Особые приметы:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 132);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 9;
            label8.Text = "Номер чипа:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 163);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 10;
            label9.Text = "Кличка:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(461, 272);
            label10.Name = "label10";
            label10.Size = new Size(167, 20);
            label10.TabIndex = 11;
            label10.Text = "Дата вакцинирования:";
            // 
            // label11
            // 
            label11.Location = new Point(461, 304);
            label11.Name = "label11";
            label11.Size = new Size(150, 45);
            label11.TabIndex = 12;
            label11.Text = "Дата окончания действия вакцины:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(461, 238);
            label12.Name = "label12";
            label12.Size = new Size(103, 20);
            label12.TabIndex = 13;
            label12.Text = "Тип вакцины:";
            // 
            // regNumb
            // 
            regNumb.Location = new Point(214, 3);
            regNumb.Name = "regNumb";
            regNumb.Size = new Size(206, 27);
            regNumb.TabIndex = 14;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(214, 36);
            category.Name = "category";
            category.Size = new Size(206, 28);
            category.TabIndex = 15;
            // 
            // sex
            // 
            sex.FormattingEnabled = true;
            sex.Location = new Point(214, 70);
            sex.Name = "sex";
            sex.Size = new Size(206, 28);
            sex.TabIndex = 16;
            // 
            // birthYear
            // 
            birthYear.Location = new Point(214, 103);
            birthYear.Name = "birthYear";
            birthYear.Size = new Size(206, 27);
            birthYear.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(specialSigns, 1, 7);
            tableLayoutPanel1.Controls.Add(locality, 1, 6);
            tableLayoutPanel1.Controls.Add(name, 1, 5);
            tableLayoutPanel1.Controls.Add(chipNumb, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 7);
            tableLayoutPanel1.Controls.Add(birthYear, 1, 3);
            tableLayoutPanel1.Controls.Add(regNumb, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(sex, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(category, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.25373F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.74627F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 154F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(423, 385);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // specialSigns
            // 
            specialSigns.Location = new Point(214, 233);
            specialSigns.MinimumSize = new Size(150, 100);
            specialSigns.Multiline = true;
            specialSigns.Name = "specialSigns";
            specialSigns.Size = new Size(206, 117);
            specialSigns.TabIndex = 21;
            // 
            // locality
            // 
            locality.Location = new Point(214, 198);
            locality.Name = "locality";
            locality.Size = new Size(206, 27);
            locality.TabIndex = 20;
            // 
            // name
            // 
            name.Location = new Point(214, 166);
            name.Name = "name";
            name.Size = new Size(206, 27);
            name.TabIndex = 19;
            // 
            // chipNumb
            // 
            chipNumb.Location = new Point(214, 135);
            chipNumb.Name = "chipNumb";
            chipNumb.Size = new Size(206, 27);
            chipNumb.TabIndex = 18;
            // 
            // actType
            // 
            actType.Location = new Point(650, 235);
            actType.Name = "actType";
            actType.Size = new Size(125, 27);
            actType.TabIndex = 19;
            // 
            // actStartDate
            // 
            actStartDate.Location = new Point(650, 272);
            actStartDate.Name = "actStartDate";
            actStartDate.Size = new Size(125, 27);
            actStartDate.TabIndex = 20;
            // 
            // actEndDate
            // 
            actEndDate.Location = new Point(650, 307);
            actEndDate.Name = "actEndDate";
            actEndDate.Size = new Size(125, 27);
            actEndDate.TabIndex = 21;
            // 
            // AnimalCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(actEndDate);
            Controls.Add(actStartDate);
            Controls.Add(actType);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(animalPhoto);
            Name = "AnimalCardForm";
            Text = "AnimalCardForm";
            Load += AnimalCardForm_Load;
            ((System.ComponentModel.ISupportInitialize)animalPhoto).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox animalPhoto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox regNumb;
        private ComboBox category;
        private ComboBox sex;
        private TextBox birthYear;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox locality;
        private TextBox name;
        private TextBox chipNumb;
        private TextBox specialSigns;
        private TextBox actType;
        private TextBox actStartDate;
        private TextBox actEndDate;
    }
}