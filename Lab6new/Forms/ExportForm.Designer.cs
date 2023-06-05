namespace Lab6new.Forms
{
    partial class ExportForm
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
            exportButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            choseFolderButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // exportButton
            // 
            exportButton.Location = new Point(129, 154);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(189, 29);
            exportButton.TabIndex = 1;
            exportButton.Text = "Экспрортировать";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // choseFolderButton
            // 
            choseFolderButton.Location = new Point(268, 74);
            choseFolderButton.Name = "choseFolderButton";
            choseFolderButton.Size = new Size(156, 29);
            choseFolderButton.TabIndex = 2;
            choseFolderButton.Text = "Выбрать папку";
            choseFolderButton.UseVisualStyleBackColor = true;
            choseFolderButton.Click += choseFolderButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите название файла";
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 270);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(choseFolderButton);
            Controls.Add(exportButton);
            Name = "ExportForm";
            Text = "ExportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exportButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private FolderBrowserDialog folderBrowserDialog2;
        private Button choseFolderButton;
        private TextBox textBox1;
        private Label label1;
    }
}