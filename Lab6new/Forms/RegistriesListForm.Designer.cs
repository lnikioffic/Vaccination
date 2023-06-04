namespace Lab6new.Forms
{
    partial class RegistriesListForm
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
            button1 = new Button();
            animalRegistryButton = new Button();
            contractRegistryButton = new Button();
            organisationRegistryButton = new Button();
            username = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(2, -1);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 0;
            button1.Text = "Реестр животных";
            button1.UseVisualStyleBackColor = true;
            // 
            // animalRegistryButton
            // 
            animalRegistryButton.Location = new Point(2, -1);
            animalRegistryButton.Name = "animalRegistryButton";
            animalRegistryButton.Size = new Size(167, 29);
            animalRegistryButton.TabIndex = 0;
            animalRegistryButton.Text = "Реестр животных";
            animalRegistryButton.UseVisualStyleBackColor = true;
            animalRegistryButton.Click += animalRegistryButton_Click;
            // 
            // contractRegistryButton
            // 
            contractRegistryButton.Location = new Point(166, -1);
            contractRegistryButton.Name = "contractRegistryButton";
            contractRegistryButton.Size = new Size(167, 29);
            contractRegistryButton.TabIndex = 1;
            contractRegistryButton.Text = "Реестр контрактов";
            contractRegistryButton.UseVisualStyleBackColor = true;
            contractRegistryButton.Click += contractRegistryButton_Click;
            // 
            // organisationRegistryButton
            // 
            organisationRegistryButton.Location = new Point(330, -1);
            organisationRegistryButton.Name = "organisationRegistryButton";
            organisationRegistryButton.Size = new Size(167, 29);
            organisationRegistryButton.TabIndex = 2;
            organisationRegistryButton.Text = "Реестр организаций";
            organisationRegistryButton.UseVisualStyleBackColor = true;
            organisationRegistryButton.Click += organisationRegistryButton_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(589, 8);
            username.Name = "username";
            username.Size = new Size(0, 20);
            username.TabIndex = 3;
            // 
            // RegistriesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(username);
            Controls.Add(organisationRegistryButton);
            Controls.Add(contractRegistryButton);
            Controls.Add(animalRegistryButton);
            Controls.Add(button1);
            Name = "RegistriesListForm";
            Text = "RegistriesListForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button animalRegistryButton;
        private Button contractRegistryButton;
        private Button organisationRegistryButton;
        private Label username;
    }
}