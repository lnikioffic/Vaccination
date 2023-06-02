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
            doctor = new TextBox();
            animal = new TextBox();
            contract = new TextBox();
            locality = new TextBox();
            startDate = new TextBox();
            duration = new TextBox();
            type = new TextBox();
            serialNumb = new TextBox();
            button1 = new Button();
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
            // doctor
            // 
            doctor.Location = new Point(288, 28);
            doctor.Name = "doctor";
            doctor.ReadOnly = true;
            doctor.Size = new Size(280, 27);
            doctor.TabIndex = 8;
            // 
            // animal
            // 
            animal.Location = new Point(288, 61);
            animal.Name = "animal";
            animal.ReadOnly = true;
            animal.Size = new Size(280, 27);
            animal.TabIndex = 9;
            // 
            // contract
            // 
            contract.Location = new Point(288, 94);
            contract.Name = "contract";
            contract.ReadOnly = true;
            contract.Size = new Size(280, 27);
            contract.TabIndex = 10;
            // 
            // locality
            // 
            locality.Location = new Point(288, 127);
            locality.Name = "locality";
            locality.ReadOnly = true;
            locality.Size = new Size(280, 27);
            locality.TabIndex = 11;
            // 
            // startDate
            // 
            startDate.Location = new Point(288, 160);
            startDate.Name = "startDate";
            startDate.ReadOnly = true;
            startDate.Size = new Size(280, 27);
            startDate.TabIndex = 12;
            // 
            // duration
            // 
            duration.Location = new Point(288, 193);
            duration.Name = "duration";
            duration.Size = new Size(280, 27);
            duration.TabIndex = 13;
            // 
            // type
            // 
            type.Location = new Point(288, 227);
            type.Name = "type";
            type.Size = new Size(280, 27);
            type.TabIndex = 14;
            // 
            // serialNumb
            // 
            serialNumb.Location = new Point(288, 260);
            serialNumb.Name = "serialNumb";
            serialNumb.Size = new Size(280, 27);
            serialNumb.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(185, 348);
            button1.Name = "button1";
            button1.Size = new Size(230, 29);
            button1.TabIndex = 16;
            button1.Text = "Вакцинировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // VaccinationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(serialNumb);
            Controls.Add(type);
            Controls.Add(duration);
            Controls.Add(startDate);
            Controls.Add(locality);
            Controls.Add(contract);
            Controls.Add(animal);
            Controls.Add(doctor);
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
        private TextBox doctor;
        private TextBox animal;
        private TextBox contract;
        private TextBox locality;
        private TextBox startDate;
        private TextBox duration;
        private TextBox type;
        private TextBox serialNumb;
        private Button button1;
    }
}