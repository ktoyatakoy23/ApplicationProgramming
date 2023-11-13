namespace Проводник_на_винформах
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
            this.CurrentPath = new System.Windows.Forms.Label();
            this.GoBack_Button = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CurrentPath
            // 
            this.CurrentPath.AutoSize = true;
            this.CurrentPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CurrentPath.ForeColor = System.Drawing.Color.Black;
            this.CurrentPath.Location = new System.Drawing.Point(72, 24);
            this.CurrentPath.Name = "CurrentPath";
            this.CurrentPath.Size = new System.Drawing.Size(79, 16);
            this.CurrentPath.TabIndex = 0;
            this.CurrentPath.Text = "Current Path";
            // 
            // GoBack_Button
            // 
            this.GoBack_Button.Location = new System.Drawing.Point(12, 12);
            this.GoBack_Button.Name = "GoBack_Button";
            this.GoBack_Button.Size = new System.Drawing.Size(40, 40);
            this.GoBack_Button.TabIndex = 1;
            this.GoBack_Button.Text = "Goback";
            this.GoBack_Button.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            this.All.FormattingEnabled = true;
            this.All.ItemHeight = 16;
            this.All.Location = new System.Drawing.Point(12, 98);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(776, 340);
            this.All.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.All);
            this.Controls.Add(this.GoBack_Button);
            this.Controls.Add(this.CurrentPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentPath;
        private System.Windows.Forms.Button GoBack_Button;
        private System.Windows.Forms.ListBox AllBox;
        private System.Windows.Forms.ListBox All;
    }
}

