namespace Exam
{
    partial class RoomsUserControl
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
            this.Cost = new System.Windows.Forms.Label();
            this.NumberRoom = new System.Windows.Forms.Label();
            this.TypeRoom = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.Label();
            this.Places = new System.Windows.Forms.Label();
            this.NumberOfRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(95)))), ((int)(((byte)(230)))));
            this.Cost.Location = new System.Drawing.Point(517, 69);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(66, 29);
            this.Cost.TabIndex = 0;
            this.Cost.Text = "Цена";
            // 
            // NumberRoom
            // 
            this.NumberRoom.AutoSize = true;
            this.NumberRoom.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberRoom.ForeColor = System.Drawing.Color.Black;
            this.NumberRoom.Location = new System.Drawing.Point(52, 33);
            this.NumberRoom.Name = "NumberRoom";
            this.NumberRoom.Size = new System.Drawing.Size(181, 29);
            this.NumberRoom.TabIndex = 1;
            this.NumberRoom.Text = "Номер комнаты";
            // 
            // TypeRoom
            // 
            this.TypeRoom.AutoSize = true;
            this.TypeRoom.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeRoom.ForeColor = System.Drawing.Color.Black;
            this.TypeRoom.Location = new System.Drawing.Point(270, 33);
            this.TypeRoom.Name = "TypeRoom";
            this.TypeRoom.Size = new System.Drawing.Size(149, 29);
            this.TypeRoom.TabIndex = 2;
            this.TypeRoom.Text = "Тип комнаты";
            // 
            // Floor
            // 
            this.Floor.AutoSize = true;
            this.Floor.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Floor.ForeColor = System.Drawing.Color.Black;
            this.Floor.Location = new System.Drawing.Point(517, 33);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(66, 29);
            this.Floor.TabIndex = 3;
            this.Floor.Text = "Этаж";
            // 
            // Places
            // 
            this.Places.AutoSize = true;
            this.Places.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Places.ForeColor = System.Drawing.Color.Black;
            this.Places.Location = new System.Drawing.Point(52, 69);
            this.Places.Name = "Places";
            this.Places.Size = new System.Drawing.Size(191, 29);
            this.Places.TabIndex = 4;
            this.Places.Text = "Количество мест";
            // 
            // NumberOfRoom
            // 
            this.NumberOfRoom.AutoSize = true;
            this.NumberOfRoom.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfRoom.ForeColor = System.Drawing.Color.Black;
            this.NumberOfRoom.Location = new System.Drawing.Point(270, 69);
            this.NumberOfRoom.Name = "NumberOfRoom";
            this.NumberOfRoom.Size = new System.Drawing.Size(218, 29);
            this.NumberOfRoom.TabIndex = 6;
            this.NumberOfRoom.Text = "Количество комнат";
            // 
            // RoomsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.NumberOfRoom);
            this.Controls.Add(this.Places);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.TypeRoom);
            this.Controls.Add(this.NumberRoom);
            this.Controls.Add(this.Cost);
            this.Name = "RoomsUserControl";
            this.Size = new System.Drawing.Size(707, 155);
            this.Load += new System.EventHandler(this.RoomsUserControl_Load);
            this.Click += new System.EventHandler(this.RoomsUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label NumberRoom;
        private System.Windows.Forms.Label TypeRoom;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Label Places;
        private System.Windows.Forms.Label NumberOfRoom;
    }
}
