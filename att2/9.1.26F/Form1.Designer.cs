namespace _9._1._26F
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.add_column = new System.Windows.Forms.Button();
            this.add_rows = new System.Windows.Forms.Button();
            this.execute_26 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_name = new System.Windows.Forms.TextBox();
            this.load_name = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(38, 38);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(629, 327);
            this.grid.TabIndex = 0;
            // 
            // add_column
            // 
            this.add_column.Location = new System.Drawing.Point(734, 38);
            this.add_column.Name = "add_column";
            this.add_column.Size = new System.Drawing.Size(139, 34);
            this.add_column.TabIndex = 1;
            this.add_column.Text = "+столбец";
            this.add_column.UseVisualStyleBackColor = true;
            // 
            // add_rows
            // 
            this.add_rows.Location = new System.Drawing.Point(734, 78);
            this.add_rows.Name = "add_rows";
            this.add_rows.Size = new System.Drawing.Size(139, 34);
            this.add_rows.TabIndex = 2;
            this.add_rows.Text = "+строка";
            this.add_rows.UseVisualStyleBackColor = true;
            // 
            // execute_26
            // 
            this.execute_26.Location = new System.Drawing.Point(734, 357);
            this.execute_26.Name = "execute_26";
            this.execute_26.Size = new System.Drawing.Size(183, 63);
            this.execute_26.TabIndex = 3;
            this.execute_26.Text = "Выполнить";
            this.execute_26.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название файла";
            // 
            // save_name
            // 
            this.save_name.Location = new System.Drawing.Point(216, 405);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(100, 26);
            this.save_name.TabIndex = 6;
            // 
            // load_name
            // 
            this.load_name.Location = new System.Drawing.Point(216, 455);
            this.load_name.Name = "load_name";
            this.load_name.Size = new System.Drawing.Size(100, 26);
            this.load_name.TabIndex = 7;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(351, 400);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(132, 37);
            this.save.TabIndex = 8;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(351, 447);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(132, 34);
            this.load.TabIndex = 9;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 504);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load_name);
            this.Controls.Add(this.save_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.execute_26);
            this.Controls.Add(this.add_rows);
            this.Controls.Add(this.add_column);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button add_column;
        private System.Windows.Forms.Button add_rows;
        private System.Windows.Forms.Button execute_26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox save_name;
        private System.Windows.Forms.TextBox load_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
    }
}

