﻿namespace Task10_Example
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputStudentsDGV = new System.Windows.Forms.DataGridView();
            this.SortStudentsBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.grants = new System.Windows.Forms.TextBox();
            this.InputStudentsDGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.InputStudentsDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputStudentsDGV
            // 
            this.InputStudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputStudentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputStudentsDGV_Name,
            this.Cender,
            this.Course,
            this.Score});
            this.InputStudentsDGV.Location = new System.Drawing.Point(13, 54);
            this.InputStudentsDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputStudentsDGV.Name = "InputStudentsDGV";
            this.InputStudentsDGV.Size = new System.Drawing.Size(816, 503);
            this.InputStudentsDGV.TabIndex = 0;
            // 
            // SortStudentsBtn
            // 
            this.SortStudentsBtn.Location = new System.Drawing.Point(13, 644);
            this.SortStudentsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SortStudentsBtn.Name = "SortStudentsBtn";
            this.SortStudentsBtn.Size = new System.Drawing.Size(816, 52);
            this.SortStudentsBtn.TabIndex = 1;
            this.SortStudentsBtn.Text = "Выполнить";
            this.SortStudentsBtn.UseVisualStyleBackColor = true;
            this.SortStudentsBtn.Click += new System.EventHandler(this.SortStudentsBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(861, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(182, 30);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // MainMenuFileSave
            // 
            this.MainMenuFileSave.Name = "MainMenuFileSave";
            this.MainMenuFileSave.Size = new System.Drawing.Size(182, 30);
            this.MainMenuFileSave.Text = "Сохранить";
            this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 600);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Количество грантов";
            // 
            // grants
            // 
            this.grants.Location = new System.Drawing.Point(411, 594);
            this.grants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grants.Name = "grants";
            this.grants.Size = new System.Drawing.Size(246, 26);
            this.grants.TabIndex = 24;
            // 
            // InputStudentsDGV_Name
            // 
            this.InputStudentsDGV_Name.HeaderText = "ФИО";
            this.InputStudentsDGV_Name.Name = "InputStudentsDGV_Name";
            this.InputStudentsDGV_Name.Width = 200;
            // 
            // Cender
            // 
            this.Cender.HeaderText = "Пол";
            this.Cender.Name = "Cender";
            // 
            // Course
            // 
            this.Course.HeaderText = "Курс";
            this.Course.Name = "Course";
            // 
            // Score
            // 
            this.Score.HeaderText = "Средний балл";
            this.Score.Name = "Score";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 710);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grants);
            this.Controls.Add(this.SortStudentsBtn);
            this.Controls.Add(this.InputStudentsDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.Text = "Заготовка для задачи 10";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputStudentsDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputStudentsDGV;
        private System.Windows.Forms.Button SortStudentsBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grants;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputStudentsDGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}

