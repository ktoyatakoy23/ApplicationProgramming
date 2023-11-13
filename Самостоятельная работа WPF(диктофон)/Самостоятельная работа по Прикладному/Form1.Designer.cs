namespace Самостоятельная_работа_по_Прикладному
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
            this.record_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.stop_record_button = new System.Windows.Forms.Button();
            this.stop_play_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // record_button
            // 
            this.record_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.record_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.record_button.Location = new System.Drawing.Point(8, 10);
            this.record_button.Name = "record_button";
            this.record_button.Size = new System.Drawing.Size(150, 50);
            this.record_button.TabIndex = 0;
            this.record_button.Text = "Запись";
            this.record_button.UseVisualStyleBackColor = false;
            this.record_button.Click += new System.EventHandler(this.record_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.White;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_button.Location = new System.Drawing.Point(270, 12);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(150, 50);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Воспроизвести";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // stop_record_button
            // 
            this.stop_record_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stop_record_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_record_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_record_button.Location = new System.Drawing.Point(8, 62);
            this.stop_record_button.Name = "stop_record_button";
            this.stop_record_button.Size = new System.Drawing.Size(150, 50);
            this.stop_record_button.TabIndex = 3;
            this.stop_record_button.Text = "Остановить запись";
            this.stop_record_button.UseVisualStyleBackColor = false;
            this.stop_record_button.Click += new System.EventHandler(this.stop_record_button_Click);
            // 
            // stop_play_button
            // 
            this.stop_play_button.BackColor = System.Drawing.Color.White;
            this.stop_play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_play_button.Location = new System.Drawing.Point(270, 62);
            this.stop_play_button.Name = "stop_play_button";
            this.stop_play_button.Size = new System.Drawing.Size(150, 50);
            this.stop_play_button.TabIndex = 4;
            this.stop_play_button.Text = "Остановить";
            this.stop_play_button.UseVisualStyleBackColor = false;
            this.stop_play_button.Click += new System.EventHandler(this.stop_play_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.White;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(164, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 100);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(429, 124);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.stop_play_button);
            this.Controls.Add(this.stop_record_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.record_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Диктофон";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button record_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button stop_record_button;
        private System.Windows.Forms.Button stop_play_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

