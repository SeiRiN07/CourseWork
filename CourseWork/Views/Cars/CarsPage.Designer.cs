﻿namespace CourseWork
{
    partial class CarsPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsPage));
            btnAddNew = new Button();
            dgvCars = new DataGridView();
            dgvTxtColumnId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveFileMenuItem = new ToolStripMenuItem();
            SaveFileAsToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpButtonsToolStripMenuItem = new ToolStripMenuItem();
            btnCustomerPage = new Button();
            btnCarsPage = new Button();
            btnRequestPage = new Button();
            btnDeleteCar = new Button();
            btnDeleteAll = new Button();
            btnEdit = new Button();
            cmbSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnSearchReset = new Button();
            btnAddUserRequest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(12, 325);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(131, 55);
            btnAddNew.TabIndex = 5;
            btnAddNew.Text = "Додати авто";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeColumns = false;
            dgvCars.AllowUserToResizeRows = false;
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Columns.AddRange(new DataGridViewColumn[] { dgvTxtColumnId, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvCars.Location = new Point(12, 130);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ScrollBars = ScrollBars.Vertical;
            dgvCars.Size = new Size(585, 189);
            dgvCars.TabIndex = 2;
            dgvCars.TabStop = false;
            // 
            // dgvTxtColumnId
            // 
            dgvTxtColumnId.HeaderText = "ID";
            dgvTxtColumnId.MaxInputLength = 3;
            dgvTxtColumnId.Name = "dgvTxtColumnId";
            dgvTxtColumnId.ReadOnly = true;
            dgvTxtColumnId.Resizable = DataGridViewTriState.False;
            dgvTxtColumnId.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Марка";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Модель";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Стан";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Рік";
            dataGridViewTextBoxColumn5.MaxInputLength = 4;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Макс. швидкість";
            dataGridViewTextBoxColumn6.MaxInputLength = 3;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Об'єм двигуну";
            dataGridViewTextBoxColumn7.MaxInputLength = 3;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Ціна";
            dataGridViewTextBoxColumn8.MaxInputLength = 7;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn8.Width = 80;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileMenuItem, SaveFileAsToolStripMenuItem, loadFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // saveFileMenuItem
            // 
            saveFileMenuItem.Name = "saveFileMenuItem";
            saveFileMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            saveFileMenuItem.Size = new Size(255, 22);
            saveFileMenuItem.Text = "Зберегти файл";
            saveFileMenuItem.Click += saveFileMenuItem_Click;
            // 
            // SaveFileAsToolStripMenuItem
            // 
            SaveFileAsToolStripMenuItem.Name = "SaveFileAsToolStripMenuItem";
            SaveFileAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            SaveFileAsToolStripMenuItem.Size = new Size(255, 22);
            SaveFileAsToolStripMenuItem.Text = "Зберегти файл як";
            SaveFileAsToolStripMenuItem.Click += SaveFileAsToolStripMenuItem_Click;
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + L";
            loadFileToolStripMenuItem.Size = new Size(255, 22);
            loadFileToolStripMenuItem.Text = "Завантажити файл";
            loadFileToolStripMenuItem.Click += loadFileMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, helpButtonsToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(75, 20);
            helpToolStripMenuItem.Text = "Допомога";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            aboutToolStripMenuItem.Size = new Size(198, 22);
            aboutToolStripMenuItem.Text = "Про програму";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // helpButtonsToolStripMenuItem
            // 
            helpButtonsToolStripMenuItem.Name = "helpButtonsToolStripMenuItem";
            helpButtonsToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            helpButtonsToolStripMenuItem.Size = new Size(198, 22);
            helpButtonsToolStripMenuItem.Text = "Допоміжні клавіші";
            helpButtonsToolStripMenuItem.Click += helpButtonsToolStripMenuItem_Click;
            // 
            // btnCustomerPage
            // 
            btnCustomerPage.Location = new Point(232, 449);
            btnCustomerPage.Name = "btnCustomerPage";
            btnCustomerPage.Size = new Size(131, 29);
            btnCustomerPage.TabIndex = 10;
            btnCustomerPage.Text = "Сторінка \"Покупці\"";
            btnCustomerPage.UseVisualStyleBackColor = true;
            btnCustomerPage.Click += btnCustomerPage_Click;
            // 
            // btnCarsPage
            // 
            btnCarsPage.Location = new Point(12, 449);
            btnCarsPage.Name = "btnCarsPage";
            btnCarsPage.Size = new Size(131, 29);
            btnCarsPage.TabIndex = 9;
            btnCarsPage.Text = "Сторінка \"Авто\"";
            btnCarsPage.UseVisualStyleBackColor = true;
            // 
            // btnRequestPage
            // 
            btnRequestPage.Location = new Point(454, 449);
            btnRequestPage.Name = "btnRequestPage";
            btnRequestPage.Size = new Size(131, 29);
            btnRequestPage.TabIndex = 11;
            btnRequestPage.Text = "Сторінка \"Заявки\"";
            btnRequestPage.UseVisualStyleBackColor = true;
            btnRequestPage.Click += btnRequestPage_Click;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(232, 325);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(131, 55);
            btnDeleteCar.TabIndex = 6;
            btnDeleteCar.Text = "Видалити авто";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(454, 325);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(131, 55);
            btnDeleteAll.TabIndex = 8;
            btnDeleteAll.Text = "Видалити все";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(232, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 57);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Редагувати авто";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEditCar_Click;
            // 
            // cmbSearch
            // 
            cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "ID", "Brand", "Price <=" });
            cmbSearch.Location = new Point(12, 27);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(155, 23);
            cmbSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 56);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(118, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSearchReset
            // 
            btnSearchReset.Location = new Point(212, 27);
            btnSearchReset.Name = "btnSearchReset";
            btnSearchReset.Size = new Size(131, 52);
            btnSearchReset.TabIndex = 4;
            btnSearchReset.Text = "Прибрати фільтр";
            btnSearchReset.UseVisualStyleBackColor = true;
            btnSearchReset.Click += btnSearchReset_Click;
            // 
            // btnAddUserRequest
            // 
            btnAddUserRequest.Location = new Point(232, 325);
            btnAddUserRequest.Name = "btnAddUserRequest";
            btnAddUserRequest.Size = new Size(131, 60);
            btnAddUserRequest.TabIndex = 12;
            btnAddUserRequest.Text = "Залишити заявку";
            btnAddUserRequest.UseVisualStyleBackColor = true;
            btnAddUserRequest.Click += btnAddUserRequest_Click;
            // 
            // CarsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 490);
            Controls.Add(btnAddUserRequest);
            Controls.Add(btnSearchReset);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteCar);
            Controls.Add(btnRequestPage);
            Controls.Add(btnCarsPage);
            Controls.Add(btnCustomerPage);
            Controls.Add(dgvCars);
            Controls.Add(btnAddNew);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "CarsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджмент автосалону";
            Load += MainWindow_Load;
            KeyDown += CarsPage_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddNew;
        private DataGridView dgvCars;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveFileMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpButtonsToolStripMenuItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnCustomerPage;
        private Button btnCarsPage;
        private Button btnRequestPage;
        private Button btnDeleteCar;
        private Button btnDeleteAll;
        private Button btnEdit;
        private ComboBox cmbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnSearchReset;
        private DataGridViewTextBoxColumn dgvTxtColumnId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private ToolStripMenuItem SaveFileAsToolStripMenuItem;
        private Button btnAddUserRequest;
    }
}
