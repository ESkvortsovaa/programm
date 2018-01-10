namespace _9._2._26
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
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load_name = new System.Windows.Forms.TextBox();
            this.save_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.execute_26 = new System.Windows.Forms.Button();
            this.add_rows = new System.Windows.Forms.Button();
            this.add_column = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(34, 24);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(647, 273);
            this.grid.TabIndex = 0;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(355, 384);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(132, 34);
            this.load.TabIndex = 19;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(355, 337);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(132, 37);
            this.save.TabIndex = 18;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // load_name
            // 
            this.load_name.Location = new System.Drawing.Point(220, 392);
            this.load_name.Name = "load_name";
            this.load_name.Size = new System.Drawing.Size(100, 26);
            this.load_name.TabIndex = 17;
            // 
            // save_name
            // 
            this.save_name.Location = new System.Drawing.Point(220, 342);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(100, 26);
            this.save_name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Название файла";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название файла";
            // 
            // execute_26
            // 
            this.execute_26.Location = new System.Drawing.Point(712, 324);
            this.execute_26.Name = "execute_26";
            this.execute_26.Size = new System.Drawing.Size(183, 63);
            this.execute_26.TabIndex = 13;
            this.execute_26.Text = "Выполнить";
            this.execute_26.UseVisualStyleBackColor = true;
            // 
            // add_rows
            // 
            this.add_rows.Location = new System.Drawing.Point(732, 94);
            this.add_rows.Name = "add_rows";
            this.add_rows.Size = new System.Drawing.Size(139, 34);
            this.add_rows.TabIndex = 12;
            this.add_rows.Text = "+строка";
            this.add_rows.UseVisualStyleBackColor = true;
            // 
            // add_column
            // 
            this.add_column.Location = new System.Drawing.Point(732, 35);
            this.add_column.Name = "add_column";
            this.add_column.Size = new System.Drawing.Size(139, 34);
            this.add_column.TabIndex = 11;
            this.add_column.Text = "+столбец";
            this.add_column.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 452);
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
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox load_name;
        private System.Windows.Forms.TextBox save_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button execute_26;
        private System.Windows.Forms.Button add_rows;
        private System.Windows.Forms.Button add_column;
    }
}

