namespace Exam
{
    partial class WorkersUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkerPictureBox = new System.Windows.Forms.PictureBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkerPictureBox
            // 
            this.WorkerPictureBox.Location = new System.Drawing.Point(15, 16);
            this.WorkerPictureBox.Name = "WorkerPictureBox";
            this.WorkerPictureBox.Size = new System.Drawing.Size(155, 188);
            this.WorkerPictureBox.TabIndex = 0;
            this.WorkerPictureBox.TabStop = false;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(185, 16);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(51, 26);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Имя";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.Location = new System.Drawing.Point(185, 52);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(56, 26);
            this.RoleLabel.TabIndex = 2;
            this.RoleLabel.Text = "Роль";
            // 
            // WorkersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.WorkerPictureBox);
            this.Name = "WorkersUserControl";
            this.Size = new System.Drawing.Size(791, 290);
            this.Load += new System.EventHandler(this.WorkersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WorkerPictureBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label RoleLabel;
    }
}
