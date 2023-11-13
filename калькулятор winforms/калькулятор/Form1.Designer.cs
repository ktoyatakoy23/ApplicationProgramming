namespace калькулятор
{
    partial class Calculator
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
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.slash_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.minus_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.equals_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.four_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.comma_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(9, 157);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(118, 60);
            this.delete_button.TabIndex = 0;
            this.delete_button.Text = "Cтереть";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(9, 421);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(56, 60);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "с";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // slash_button
            // 
            this.slash_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.slash_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.slash_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slash_button.Location = new System.Drawing.Point(195, 157);
            this.slash_button.Name = "slash_button";
            this.slash_button.Size = new System.Drawing.Size(56, 60);
            this.slash_button.TabIndex = 2;
            this.slash_button.Text = "\\";
            this.slash_button.UseVisualStyleBackColor = false;
            this.slash_button.Click += new System.EventHandler(this.slash_button_Click);
            // 
            // multiply_button
            // 
            this.multiply_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.multiply_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply_button.Location = new System.Drawing.Point(195, 223);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(56, 60);
            this.multiply_button.TabIndex = 3;
            this.multiply_button.Text = "Х";
            this.multiply_button.UseVisualStyleBackColor = false;
            this.multiply_button.Click += new System.EventHandler(this.multiply_button_Click);
            // 
            // minus_button
            // 
            this.minus_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.minus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_button.Location = new System.Drawing.Point(195, 289);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(56, 60);
            this.minus_button.TabIndex = 4;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = false;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plus_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_button.Location = new System.Drawing.Point(195, 355);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(56, 60);
            this.plus_button.TabIndex = 5;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // equals_button
            // 
            this.equals_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equals_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equals_button.Location = new System.Drawing.Point(133, 421);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(118, 60);
            this.equals_button.TabIndex = 6;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = false;
            this.equals_button.Click += new System.EventHandler(this.equals_button_Click);
            // 
            // three_button
            // 
            this.three_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three_button.Location = new System.Drawing.Point(133, 355);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(56, 60);
            this.three_button.TabIndex = 9;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.three_button_Click);
            // 
            // six_button
            // 
            this.six_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six_button.Location = new System.Drawing.Point(133, 289);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(56, 60);
            this.six_button.TabIndex = 8;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.six_button_Click);
            // 
            // nine_button
            // 
            this.nine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine_button.Location = new System.Drawing.Point(133, 223);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(56, 60);
            this.nine_button.TabIndex = 7;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.nine_button_Click);
            // 
            // two_button
            // 
            this.two_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two_button.Location = new System.Drawing.Point(71, 355);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(56, 60);
            this.two_button.TabIndex = 12;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.two_button_Click);
            // 
            // five_button
            // 
            this.five_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five_button.Location = new System.Drawing.Point(71, 289);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(56, 60);
            this.five_button.TabIndex = 11;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.five_button_Click);
            // 
            // eight_button
            // 
            this.eight_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight_button.Location = new System.Drawing.Point(71, 223);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(56, 60);
            this.eight_button.TabIndex = 10;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.eight_button_Click);
            // 
            // one_button
            // 
            this.one_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one_button.Location = new System.Drawing.Point(9, 355);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(56, 60);
            this.one_button.TabIndex = 15;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // four_button
            // 
            this.four_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four_button.Location = new System.Drawing.Point(9, 289);
            this.four_button.Name = "four_button";
            this.four_button.Size = new System.Drawing.Size(56, 60);
            this.four_button.TabIndex = 14;
            this.four_button.Text = "4";
            this.four_button.UseVisualStyleBackColor = true;
            this.four_button.Click += new System.EventHandler(this.four_button_Click);
            // 
            // seven_button
            // 
            this.seven_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven_button.Location = new System.Drawing.Point(9, 223);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(56, 60);
            this.seven_button.TabIndex = 13;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.seven_button_Click);
            // 
            // zero_button
            // 
            this.zero_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero_button.Location = new System.Drawing.Point(71, 421);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(56, 60);
            this.zero_button.TabIndex = 16;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.zero_button_Click);
            // 
            // comma_button
            // 
            this.comma_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comma_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comma_button.Location = new System.Drawing.Point(133, 157);
            this.comma_button.Name = "comma_button";
            this.comma_button.Size = new System.Drawing.Size(56, 60);
            this.comma_button.TabIndex = 17;
            this.comma_button.Text = ",";
            this.comma_button.UseVisualStyleBackColor = false;
            this.comma_button.Click += new System.EventHandler(this.comma_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(9, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 87);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 19;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comma_button);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.four_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.equals_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.slash_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.delete_button);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button slash_button;
        private System.Windows.Forms.Button multiply_button;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button equals_button;
        private System.Windows.Forms.Button three_button;
        private System.Windows.Forms.Button six_button;
        private System.Windows.Forms.Button nine_button;
        private System.Windows.Forms.Button two_button;
        private System.Windows.Forms.Button five_button;
        private System.Windows.Forms.Button eight_button;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button four_button;
        private System.Windows.Forms.Button seven_button;
        private System.Windows.Forms.Button zero_button;
        private System.Windows.Forms.Button comma_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

