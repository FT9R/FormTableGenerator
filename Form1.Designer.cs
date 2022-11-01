namespace FormTableGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Resolution_TB = new System.Windows.Forms.TextBox();
            this.Resolution_LB = new System.Windows.Forms.Label();
            this.Samples_LB = new System.Windows.Forms.Label();
            this.Samples_TB = new System.Windows.Forms.TextBox();
            this.Start_BT = new System.Windows.Forms.Button();
            this.Rows_LB = new System.Windows.Forms.Label();
            this.Rows_TB = new System.Windows.Forms.TextBox();
            this.Sin_RB = new System.Windows.Forms.RadioButton();
            this.Triangle_RB = new System.Windows.Forms.RadioButton();
            this.Saw_RB = new System.Windows.Forms.RadioButton();
            this.Noize_RB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Resolution_TB
            // 
            this.Resolution_TB.Location = new System.Drawing.Point(27, 20);
            this.Resolution_TB.Name = "Resolution_TB";
            this.Resolution_TB.Size = new System.Drawing.Size(51, 20);
            this.Resolution_TB.TabIndex = 0;
            this.Resolution_TB.Text = "12";
            // 
            // Resolution_LB
            // 
            this.Resolution_LB.AutoSize = true;
            this.Resolution_LB.Location = new System.Drawing.Point(24, 4);
            this.Resolution_LB.Name = "Resolution_LB";
            this.Resolution_LB.Size = new System.Drawing.Size(57, 13);
            this.Resolution_LB.TabIndex = 1;
            this.Resolution_LB.Text = "Resolution";
            // 
            // Samples_LB
            // 
            this.Samples_LB.AutoSize = true;
            this.Samples_LB.Location = new System.Drawing.Point(24, 43);
            this.Samples_LB.Name = "Samples_LB";
            this.Samples_LB.Size = new System.Drawing.Size(47, 13);
            this.Samples_LB.TabIndex = 3;
            this.Samples_LB.Text = "Samples";
            // 
            // Samples_TB
            // 
            this.Samples_TB.Location = new System.Drawing.Point(27, 59);
            this.Samples_TB.Name = "Samples_TB";
            this.Samples_TB.Size = new System.Drawing.Size(51, 20);
            this.Samples_TB.TabIndex = 2;
            this.Samples_TB.Text = "128";
            // 
            // Start_BT
            // 
            this.Start_BT.Location = new System.Drawing.Point(116, 98);
            this.Start_BT.Name = "Start_BT";
            this.Start_BT.Size = new System.Drawing.Size(51, 20);
            this.Start_BT.TabIndex = 4;
            this.Start_BT.Text = "Start";
            this.Start_BT.UseVisualStyleBackColor = true;
            this.Start_BT.Click += new System.EventHandler(this.Start_BT_Click);
            // 
            // Rows_LB
            // 
            this.Rows_LB.AutoSize = true;
            this.Rows_LB.Location = new System.Drawing.Point(24, 82);
            this.Rows_LB.Name = "Rows_LB";
            this.Rows_LB.Size = new System.Drawing.Size(34, 13);
            this.Rows_LB.TabIndex = 6;
            this.Rows_LB.Text = "Rows";
            // 
            // Rows_TB
            // 
            this.Rows_TB.Location = new System.Drawing.Point(27, 98);
            this.Rows_TB.Name = "Rows_TB";
            this.Rows_TB.Size = new System.Drawing.Size(51, 20);
            this.Rows_TB.TabIndex = 5;
            this.Rows_TB.Text = "8";
            // 
            // Sin_RB
            // 
            this.Sin_RB.AutoSize = true;
            this.Sin_RB.Checked = true;
            this.Sin_RB.Location = new System.Drawing.Point(116, 4);
            this.Sin_RB.Name = "Sin_RB";
            this.Sin_RB.Size = new System.Drawing.Size(40, 17);
            this.Sin_RB.TabIndex = 7;
            this.Sin_RB.TabStop = true;
            this.Sin_RB.Text = "Sin";
            this.Sin_RB.UseVisualStyleBackColor = true;
            // 
            // Triangle_RB
            // 
            this.Triangle_RB.AutoSize = true;
            this.Triangle_RB.Location = new System.Drawing.Point(116, 27);
            this.Triangle_RB.Name = "Triangle_RB";
            this.Triangle_RB.Size = new System.Drawing.Size(63, 17);
            this.Triangle_RB.TabIndex = 8;
            this.Triangle_RB.TabStop = true;
            this.Triangle_RB.Text = "Triangle";
            this.Triangle_RB.UseVisualStyleBackColor = true;
            // 
            // Saw_RB
            // 
            this.Saw_RB.AutoSize = true;
            this.Saw_RB.Location = new System.Drawing.Point(116, 50);
            this.Saw_RB.Name = "Saw_RB";
            this.Saw_RB.Size = new System.Drawing.Size(46, 17);
            this.Saw_RB.TabIndex = 9;
            this.Saw_RB.TabStop = true;
            this.Saw_RB.Text = "Saw";
            this.Saw_RB.UseVisualStyleBackColor = true;
            // 
            // Noize_RB
            // 
            this.Noize_RB.AutoSize = true;
            this.Noize_RB.Location = new System.Drawing.Point(116, 73);
            this.Noize_RB.Name = "Noize_RB";
            this.Noize_RB.Size = new System.Drawing.Size(52, 17);
            this.Noize_RB.TabIndex = 10;
            this.Noize_RB.TabStop = true;
            this.Noize_RB.Text = "Noize";
            this.Noize_RB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(194, 129);
            this.Controls.Add(this.Noize_RB);
            this.Controls.Add(this.Saw_RB);
            this.Controls.Add(this.Triangle_RB);
            this.Controls.Add(this.Sin_RB);
            this.Controls.Add(this.Rows_LB);
            this.Controls.Add(this.Rows_TB);
            this.Controls.Add(this.Start_BT);
            this.Controls.Add(this.Samples_LB);
            this.Controls.Add(this.Samples_TB);
            this.Controls.Add(this.Resolution_LB);
            this.Controls.Add(this.Resolution_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTableGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Resolution_TB;
        private System.Windows.Forms.Label Resolution_LB;
        private System.Windows.Forms.Label Samples_LB;
        private System.Windows.Forms.TextBox Samples_TB;
        private System.Windows.Forms.Button Start_BT;
        private System.Windows.Forms.Label Rows_LB;
        private System.Windows.Forms.TextBox Rows_TB;
        private System.Windows.Forms.RadioButton Sin_RB;
        private System.Windows.Forms.RadioButton Triangle_RB;
        private System.Windows.Forms.RadioButton Saw_RB;
        private System.Windows.Forms.RadioButton Noize_RB;
    }
}

