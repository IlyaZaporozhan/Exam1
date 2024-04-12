namespace Exam
{
    partial class DirectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.RoomsButton = new System.Windows.Forms.Button();
            this.WorkersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomsButton
            // 
            this.RoomsButton.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsButton.Location = new System.Drawing.Point(485, 118);
            this.RoomsButton.Name = "RoomsButton";
            this.RoomsButton.Size = new System.Drawing.Size(146, 93);
            this.RoomsButton.TabIndex = 3;
            this.RoomsButton.Text = "Номера";
            this.RoomsButton.UseVisualStyleBackColor = true;
            this.RoomsButton.Click += new System.EventHandler(this.RoomsButton_Click);
            // 
            // WorkersButton
            // 
            this.WorkersButton.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkersButton.Location = new System.Drawing.Point(161, 118);
            this.WorkersButton.Name = "WorkersButton";
            this.WorkersButton.Size = new System.Drawing.Size(146, 93);
            this.WorkersButton.TabIndex = 2;
            this.WorkersButton.Text = "Сотрудники";
            this.WorkersButton.UseVisualStyleBackColor = true;
            this.WorkersButton.Click += new System.EventHandler(this.WorkersButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomsButton);
            this.Controls.Add(this.WorkersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RoomsButton;
        private System.Windows.Forms.Button WorkersButton;
    }
}