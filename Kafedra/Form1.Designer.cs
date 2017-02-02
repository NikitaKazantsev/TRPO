namespace Kafedra
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
            this.Open_Kafedra_Button = new System.Windows.Forms.Button();
            this.Open_Otdel_Kadrov_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_Kafedra_Button
            // 
            this.Open_Kafedra_Button.Location = new System.Drawing.Point(12, 26);
            this.Open_Kafedra_Button.Name = "Open_Kafedra_Button";
            this.Open_Kafedra_Button.Size = new System.Drawing.Size(189, 50);
            this.Open_Kafedra_Button.TabIndex = 0;
            this.Open_Kafedra_Button.Text = "Кафедра";
            this.Open_Kafedra_Button.UseVisualStyleBackColor = true;
            this.Open_Kafedra_Button.Click += new System.EventHandler(this.Open_Kafedra_Button_Click);
            // 
            // Open_Otdel_Kadrov_Button
            // 
            this.Open_Otdel_Kadrov_Button.Location = new System.Drawing.Point(12, 82);
            this.Open_Otdel_Kadrov_Button.Name = "Open_Otdel_Kadrov_Button";
            this.Open_Otdel_Kadrov_Button.Size = new System.Drawing.Size(189, 50);
            this.Open_Otdel_Kadrov_Button.TabIndex = 1;
            this.Open_Otdel_Kadrov_Button.Text = "Отдел кадров";
            this.Open_Otdel_Kadrov_Button.UseVisualStyleBackColor = true;
            this.Open_Otdel_Kadrov_Button.Click += new System.EventHandler(this.Open_Otdel_Kadrov_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(12, 138);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(189, 50);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "Выход";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 337);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Open_Otdel_Kadrov_Button);
            this.Controls.Add(this.Open_Kafedra_Button);
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_Kafedra_Button;
        private System.Windows.Forms.Button Open_Otdel_Kadrov_Button;
        private System.Windows.Forms.Button Close_Button;
    }
}

