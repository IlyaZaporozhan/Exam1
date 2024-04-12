namespace Exam
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AdminButton = new System.Windows.Forms.Button();
            this.CleanerButton = new System.Windows.Forms.Button();
            this.DirectorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButton.Location = new System.Drawing.Point(61, 70);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(196, 94);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.Text = "Администратор\r\nЗала";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // CleanerButton
            // 
            this.CleanerButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanerButton.Location = new System.Drawing.Point(504, 70);
            this.CleanerButton.Name = "CleanerButton";
            this.CleanerButton.Size = new System.Drawing.Size(196, 94);
            this.CleanerButton.TabIndex = 1;
            this.CleanerButton.Text = "Уборщик";
            this.CleanerButton.UseVisualStyleBackColor = true;
            this.CleanerButton.Click += new System.EventHandler(this.CleanerButton_Click);
            // 
            // DirectorButton
            // 
            this.DirectorButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectorButton.Location = new System.Drawing.Point(297, 275);
            this.DirectorButton.Name = "DirectorButton";
            this.DirectorButton.Size = new System.Drawing.Size(196, 94);
            this.DirectorButton.TabIndex = 2;
            this.DirectorButton.Text = "Директор";
            this.DirectorButton.UseVisualStyleBackColor = true;
            this.DirectorButton.Click += new System.EventHandler(this.DirectorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DirectorButton);
            this.Controls.Add(this.CleanerButton);
            this.Controls.Add(this.AdminButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button CleanerButton;
        private System.Windows.Forms.Button DirectorButton;
    }
}

