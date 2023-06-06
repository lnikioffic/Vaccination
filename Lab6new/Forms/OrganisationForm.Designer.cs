namespace Lab6new.Forms
{
    partial class OrganisationForm
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
            label2 = new Label();
            localityFilter = new ComboBox();
            label1 = new Label();
            orgTypeFilter = new ComboBox();
            innFilter = new TextBox();
            label3 = new Label();
            searchButton = new Button();
            sortBox = new GroupBox();
            nullSortRadio = new RadioButton();
            localityRadio = new RadioButton();
            typeRadio = new RadioButton();
            fullnameRadio = new RadioButton();
            typeSortBox = new GroupBox();
            descendingRadio = new RadioButton();
            radioButton4 = new RadioButton();
            organisationTable = new DataGridView();
            showCardButton = new Button();
            entityBox = new GroupBox();
            oooCheckBox = new CheckBox();
            ipCheckBox = new CheckBox();
            exportButton = new Button();
            sortBox.SuspendLayout();
            typeSortBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)organisationTable).BeginInit();
            entityBox.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 46);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 16;
            label2.Text = "Населеный пункт";
            // 
            // localityFilter
            // 
            localityFilter.FormattingEnabled = true;
            localityFilter.Location = new Point(498, 69);
            localityFilter.Name = "localityFilter";
            localityFilter.Size = new Size(185, 28);
            localityFilter.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 42);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 18;
            label1.Text = "Тип организации";
            // 
            // orgTypeFilter
            // 
            orgTypeFilter.FormattingEnabled = true;
            orgTypeFilter.Location = new Point(214, 68);
            orgTypeFilter.Name = "orgTypeFilter";
            orgTypeFilter.Size = new Size(269, 28);
            orgTypeFilter.TabIndex = 17;
            // 
            // innFilter
            // 
            innFilter.Location = new Point(12, 69);
            innFilter.Name = "innFilter";
            innFilter.Size = new Size(185, 27);
            innFilter.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 43);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 20;
            label3.Text = "ИНН";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(694, 69);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 22;
            searchButton.Text = "Найти";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // sortBox
            // 
            sortBox.Controls.Add(nullSortRadio);
            sortBox.Controls.Add(localityRadio);
            sortBox.Controls.Add(typeRadio);
            sortBox.Controls.Add(fullnameRadio);
            sortBox.Location = new Point(162, 104);
            sortBox.Name = "sortBox";
            sortBox.Size = new Size(377, 57);
            sortBox.TabIndex = 23;
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
            // localityRadio
            // 
            localityRadio.AutoSize = true;
            localityRadio.Location = new Point(179, 25);
            localityRadio.Name = "localityRadio";
            localityRadio.Size = new Size(101, 24);
            localityRadio.TabIndex = 1;
            localityRadio.Text = "Нас. пункт";
            localityRadio.UseVisualStyleBackColor = true;
            // 
            // typeRadio
            // 
            typeRadio.AutoSize = true;
            typeRadio.Location = new Point(117, 25);
            typeRadio.Name = "typeRadio";
            typeRadio.Size = new Size(56, 24);
            typeRadio.TabIndex = 0;
            typeRadio.Text = "Тип";
            typeRadio.UseVisualStyleBackColor = true;
            // 
            // fullnameRadio
            // 
            fullnameRadio.AutoSize = true;
            fullnameRadio.Location = new Point(6, 25);
            fullnameRadio.Name = "fullnameRadio";
            fullnameRadio.Size = new Size(98, 24);
            fullnameRadio.TabIndex = 0;
            fullnameRadio.Text = "Название";
            fullnameRadio.UseVisualStyleBackColor = true;
            // 
            // typeSortBox
            // 
            typeSortBox.Controls.Add(descendingRadio);
            typeSortBox.Controls.Add(radioButton4);
            typeSortBox.Location = new Point(545, 104);
            typeSortBox.Name = "typeSortBox";
            typeSortBox.Size = new Size(243, 57);
            typeSortBox.TabIndex = 16;
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
            // organisationTable
            // 
            organisationTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            organisationTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            organisationTable.Location = new Point(12, 182);
            organisationTable.Name = "organisationTable";
            organisationTable.RowHeadersWidth = 51;
            organisationTable.RowTemplate.Height = 29;
            organisationTable.Size = new Size(776, 221);
            organisationTable.TabIndex = 24;
            // 
            // showCardButton
            // 
            showCardButton.Location = new Point(426, 414);
            showCardButton.Name = "showCardButton";
            showCardButton.Size = new Size(135, 29);
            showCardButton.TabIndex = 25;
            showCardButton.Text = "Показать";
            showCardButton.UseVisualStyleBackColor = true;
            showCardButton.Click += showCardButton_Click;
            // 
            // entityBox
            // 
            entityBox.Controls.Add(oooCheckBox);
            entityBox.Controls.Add(ipCheckBox);
            entityBox.Location = new Point(12, 104);
            entityBox.Name = "entityBox";
            entityBox.Size = new Size(129, 57);
            entityBox.TabIndex = 26;
            entityBox.TabStop = false;
            entityBox.Text = "Лицо";
            // 
            // oooCheckBox
            // 
            oooCheckBox.AutoSize = true;
            oooCheckBox.Checked = true;
            oooCheckBox.CheckState = CheckState.Checked;
            oooCheckBox.Location = new Point(6, 26);
            oooCheckBox.Name = "oooCheckBox";
            oooCheckBox.Size = new Size(58, 24);
            oooCheckBox.TabIndex = 11;
            oooCheckBox.Text = "Юр.";
            oooCheckBox.UseVisualStyleBackColor = true;
            // 
            // ipCheckBox
            // 
            ipCheckBox.AutoSize = true;
            ipCheckBox.Checked = true;
            ipCheckBox.CheckState = CheckState.Checked;
            ipCheckBox.Location = new Point(76, 26);
            ipCheckBox.Name = "ipCheckBox";
            ipCheckBox.Size = new Size(61, 24);
            ipCheckBox.TabIndex = 12;
            ipCheckBox.Text = "Физ.";
            ipCheckBox.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(210, 414);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(135, 29);
            exportButton.TabIndex = 27;
            exportButton.Text = "Экспортировть";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // OrganisationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportButton);
            Controls.Add(entityBox);
            Controls.Add(showCardButton);
            Controls.Add(organisationTable);
            Controls.Add(typeSortBox);
            Controls.Add(sortBox);
            Controls.Add(searchButton);
            Controls.Add(innFilter);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(orgTypeFilter);
            Controls.Add(label2);
            Controls.Add(localityFilter);
            Name = "OrganisationForm";
            Text = "OrganisationForm";
            Activated += OrganisationForm_Activated;
            Load += OrganisationForm_Load;
            Controls.SetChildIndex(localityFilter, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(orgTypeFilter, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(innFilter, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(sortBox, 0);
            Controls.SetChildIndex(typeSortBox, 0);
            Controls.SetChildIndex(organisationTable, 0);
            Controls.SetChildIndex(showCardButton, 0);
            Controls.SetChildIndex(entityBox, 0);
            Controls.SetChildIndex(exportButton, 0);
            sortBox.ResumeLayout(false);
            sortBox.PerformLayout();
            typeSortBox.ResumeLayout(false);
            typeSortBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)organisationTable).EndInit();
            entityBox.ResumeLayout(false);
            entityBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox localityFilter;
        private Label label1;
        private ComboBox orgTypeFilter;
        private TextBox innFilter;
        private Label label3;
        private Button searchButton;
        private GroupBox sortBox;
        private RadioButton nullSortRadio;
        private RadioButton localityRadio;
        private RadioButton typeRadio;
        private RadioButton fullnameRadio;
        private GroupBox typeSortBox;
        private RadioButton descendingRadio;
        private RadioButton radioButton4;
        private DataGridView organisationTable;
        private Button showCardButton;
        private GroupBox entityBox;
        private CheckBox oooCheckBox;
        private CheckBox ipCheckBox;
        private Button exportButton;
    }
}