namespace Lab6new.Forms
{
    partial class VaccinationForm
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            userTextBox = new TextBox();
            animalTextBox = new TextBox();
            contractTextBox = new TextBox();
            startDateTextBox = new TextBox();
            durationTextBox = new TextBox();
            typeTextBox = new TextBox();
            serialNumbTextBox = new TextBox();
            addButton = new Button();
            changeButton = new Button();
            this.localityComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Врач";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Животное";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Контракт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 133);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = "Населеный пункт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 163);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 4;
            label5.Text = "Дата вакцинации";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 195);
            label6.Name = "label6";
            label6.Size = new Size(170, 20);
            label6.TabIndex = 5;
            label6.Text = "Длительность вакцины";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 227);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 6;
            label7.Text = "Тип вакцины";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 259);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 7;
            label8.Text = "Серийный номер";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(288, 28);
            userTextBox.Name = "userTextBox";
            userTextBox.ReadOnly = true;
            userTextBox.Size = new Size(280, 27);
            userTextBox.TabIndex = 8;
            // 
            // animalTextBox
            // 
            animalTextBox.Location = new Point(288, 61);
            animalTextBox.Name = "animalTextBox";
            animalTextBox.ReadOnly = true;
            animalTextBox.Size = new Size(280, 27);
            animalTextBox.TabIndex = 9;
            // 
            // contractTextBox
            // 
            contractTextBox.Location = new Point(288, 94);
            contractTextBox.Name = "contractTextBox";
            contractTextBox.ReadOnly = true;
            contractTextBox.Size = new Size(280, 27);
            contractTextBox.TabIndex = 10;
            // 
            // startDateTextBox
            // 
            startDateTextBox.Location = new Point(288, 160);
            startDateTextBox.Name = "startDateTextBox";
            startDateTextBox.ReadOnly = true;
            startDateTextBox.Size = new Size(280, 27);
            startDateTextBox.TabIndex = 12;
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(288, 193);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(280, 27);
            durationTextBox.TabIndex = 13;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(288, 227);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(280, 27);
            typeTextBox.TabIndex = 14;
            // 
            // serialNumbTextBox
            // 
            serialNumbTextBox.Location = new Point(288, 260);
            serialNumbTextBox.Name = "serialNumbTextBox";
            serialNumbTextBox.Size = new Size(280, 27);
            serialNumbTextBox.TabIndex = 15;
            // 
            // addButton
            // 
            addButton.Location = new Point(185, 348);
            addButton.Name = "addButton";
            addButton.Size = new Size(230, 29);
            addButton.TabIndex = 16;
            addButton.Text = "Вакцинировать";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(185, 348);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(230, 29);
            changeButton.TabIndex = 17;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Visible = false;
            changeButton.Click += changeButton_Click;
            // 
            // localityComboBox
            // 
            this.localityComboBox.FormattingEnabled = true;
            this.localityComboBox.Location = new Point(288, 127);
            this.localityComboBox.Name = "localityComboBox";
            this.localityComboBox.Size = new Size(280, 28);
            this.localityComboBox.TabIndex = 18;
            // 
            // VaccinationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.localityComboBox);
            Controls.Add(changeButton);
            Controls.Add(addButton);
            Controls.Add(serialNumbTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(durationTextBox);
            Controls.Add(startDateTextBox);
            Controls.Add(contractTextBox);
            Controls.Add(animalTextBox);
            Controls.Add(userTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VaccinationForm";
            Text = "VaccinationForm";
            Load += VaccinationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox userTextBox;
        private TextBox animalTextBox;
        private TextBox contractTextBox;
        private TextBox startDateTextBox;
        private TextBox durationTextBox;
        private TextBox typeTextBox;
        private TextBox serialNumbTextBox;
        private Button addButton;
        private Button changeButton;
        private ComboBox localityComboBox;
    }
}