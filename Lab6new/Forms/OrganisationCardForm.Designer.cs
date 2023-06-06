namespace Lab6new.Forms
{
    partial class OrganisationCardForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            entity = new TextBox();
            type = new TextBox();
            label1 = new Label();
            address = new TextBox();
            fullname = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label2 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            inn = new TextBox();
            kpp = new TextBox();
            locality = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(entity, 1, 5);
            tableLayoutPanel1.Controls.Add(type, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(address, 1, 3);
            tableLayoutPanel1.Controls.Add(fullname, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(inn, 1, 1);
            tableLayoutPanel1.Controls.Add(kpp, 1, 2);
            tableLayoutPanel1.Controls.Add(locality, 1, 6);
            tableLayoutPanel1.Location = new Point(12, 29);
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
            tableLayoutPanel1.TabIndex = 19;
            // 
            // entity
            // 
            entity.Location = new Point(214, 166);
            entity.Name = "entity";
            entity.Size = new Size(206, 27);
            entity.TabIndex = 19;
            // 
            // type
            // 
            type.Location = new Point(214, 135);
            type.Name = "type";
            type.Size = new Size(206, 27);
            type.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 2;
            label1.Text = "Полное имя:";
            // 
            // address
            // 
            address.Location = new Point(214, 103);
            address.Name = "address";
            address.Size = new Size(206, 27);
            address.TabIndex = 17;
            // 
            // fullname
            // 
            fullname.Location = new Point(214, 3);
            fullname.Name = "fullname";
            fullname.Size = new Size(206, 27);
            fullname.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 163);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 10;
            label9.Text = "Лицо:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "ИНН:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 132);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 9;
            label8.Text = "Тип организации:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "КПП:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Адрес:";
            // 
            // inn
            // 
            inn.Location = new Point(214, 36);
            inn.Name = "inn";
            inn.Size = new Size(206, 27);
            inn.TabIndex = 20;
            // 
            // kpp
            // 
            kpp.Location = new Point(214, 70);
            kpp.Name = "kpp";
            kpp.Size = new Size(206, 27);
            kpp.TabIndex = 21;
            // 
            // locality
            // 
            locality.Location = new Point(214, 198);
            locality.Name = "locality";
            locality.Size = new Size(206, 27);
            locality.TabIndex = 22;
            // 
            // OrganisationCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "OrganisationCardForm";
            Text = "OrganisationCardFormcs";
            Load += OrganisationCardFormcs_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox entity;
        private TextBox type;
        private Label label1;
        private TextBox address;
        private TextBox fullname;
        private Label label9;
        private Label label5;
        private Label label2;
        private Label label8;
        private Label label3;
        private Label label4;
        private TextBox inn;
        private TextBox kpp;
        private TextBox locality;
    }
}