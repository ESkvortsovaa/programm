namespace task_in_form
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
            this.components = new System.ComponentModel.Container();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save_name = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.load_name = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.add_rows = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grants = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Gender,
            this.Course,
            this.Score});
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 10;
            this.grid.Size = new System.Drawing.Size(597, 402);
            this.grid.TabIndex = 0;
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
            // save_name
            // 
            this.save_name.Location = new System.Drawing.Point(106, 423);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(89, 20);
            this.save_name.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(201, 421);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название файла";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(201, 450);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 5;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // load_name
            // 
            this.load_name.Location = new System.Drawing.Point(106, 452);
            this.load_name.Name = "load_name";
            this.load_name.Size = new System.Drawing.Size(89, 20);
            this.load_name.TabIndex = 4;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(326, 450);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(283, 23);
            this.execute.TabIndex = 7;
            this.execute.Text = "Выполнить";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // add_rows
            // 
            this.add_rows.Location = new System.Drawing.Point(627, 12);
            this.add_rows.Name = "add_rows";
            this.add_rows.Size = new System.Drawing.Size(75, 23);
            this.add_rows.TabIndex = 9;
            this.add_rows.Text = "+ строка";
            this.add_rows.UseVisualStyleBackColor = true;
            this.add_rows.Click += new System.EventHandler(this.add_rows_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество грантов";
            // 
            // grants
            // 
            this.grants.Location = new System.Drawing.Point(444, 423);
            this.grants.Name = "grants";
            this.grants.Size = new System.Drawing.Size(165, 20);
            this.grants.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 483);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.BindingSource pointBindingSource;
        private System.Windows.Forms.TextBox save_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox load_name;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button add_rows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grants;
    }
}

