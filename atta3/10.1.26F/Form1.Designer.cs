﻿namespace _10._1._26F
{
    partial class Form1
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
            this.add_rows = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.load_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.save_name = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.ToolStripMenuItem();
            this.execute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grants = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_rows
            // 
            this.add_rows.Location = new System.Drawing.Point(976, 52);
            this.add_rows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_rows.Name = "add_rows";
            this.add_rows.Size = new System.Drawing.Size(112, 47);
            this.add_rows.TabIndex = 21;
            this.add_rows.Text = "+ строка";
            this.add_rows.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 504);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название файла";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(299, 504);
            this.load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(122, 28);
            this.load.TabIndex = 18;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            // 
            // load_name
            // 
            this.load_name.Location = new System.Drawing.Point(156, 499);
            this.load_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.load_name.Name = "load_name";
            this.load_name.Size = new System.Drawing.Size(132, 26);
            this.load_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 459);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название файла";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(299, 452);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(122, 29);
            this.save.TabIndex = 15;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // save_name
            // 
            this.save_name.Location = new System.Drawing.Point(156, 455);
            this.save_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(132, 26);
            this.save_name.TabIndex = 14;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Gender,
            this.Course,
            this.Score});
            this.grid.Location = new System.Drawing.Point(13, 52);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 10;
            this.grid.Size = new System.Drawing.Size(898, 367);
            this.grid.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileDialog1,
            this.saveFileDialog1});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(65, 29);
            this.MenuFile.Text = "Файл";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Name = "openFileDialog1";
            this.openFileDialog1.Size = new System.Drawing.Size(210, 30);
            this.openFileDialog1.Text = "Открыть";
            this.openFileDialog1.Click += new System.EventHandler(this.openFileDialog1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Name = "saveFileDialog1";
            this.saveFileDialog1.Size = new System.Drawing.Size(210, 30);
            this.saveFileDialog1.Text = "Сохранить";
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(488, 480);
            this.execute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(424, 49);
            this.execute.TabIndex = 20;
            this.execute.Text = "Выполнить";
            this.execute.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Количество грантов";
            // 
            // grants
            // 
            this.grants.Location = new System.Drawing.Point(665, 439);
            this.grants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grants.Name = "grants";
            this.grants.Size = new System.Drawing.Size(246, 26);
            this.grants.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 568);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grants);
            this.Controls.Add(this.add_rows);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.load);
            this.Controls.Add(this.load_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.save_name);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_rows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox load_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox save_name;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveFileDialog1;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grants;
    }
}
