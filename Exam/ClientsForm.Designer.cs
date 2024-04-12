namespace Exam
{
    partial class ClientsForm
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
            this.components = new System.ComponentModel.Container();
            this.ClientsdataGridView = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasportSeriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBuffetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsdataGridView
            // 
            this.ClientsdataGridView.AutoGenerateColumns = false;
            this.ClientsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.pasportNumberDataGridViewTextBoxColumn,
            this.pasportSeriesDataGridViewTextBoxColumn,
            this.registrationDataGridViewTextBoxColumn,
            this.iDWorkersDataGridViewTextBoxColumn,
            this.clientBuffetDataGridViewTextBoxColumn,
            this.workersDataGridViewTextBoxColumn,
            this.clientsRoomsDataGridViewTextBoxColumn});
            this.ClientsdataGridView.DataSource = this.clientsBindingSource;
            this.ClientsdataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsdataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClientsdataGridView.Name = "ClientsdataGridView";
            this.ClientsdataGridView.Size = new System.Drawing.Size(697, 345);
            this.ClientsdataGridView.TabIndex = 0;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataSource = typeof(Exam.ModelEF.Clients);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // pasportNumberDataGridViewTextBoxColumn
            // 
            this.pasportNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pasportNumberDataGridViewTextBoxColumn.DataPropertyName = "PasportNumber";
            this.pasportNumberDataGridViewTextBoxColumn.HeaderText = "PasportNumber";
            this.pasportNumberDataGridViewTextBoxColumn.Name = "pasportNumberDataGridViewTextBoxColumn";
            // 
            // pasportSeriesDataGridViewTextBoxColumn
            // 
            this.pasportSeriesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pasportSeriesDataGridViewTextBoxColumn.DataPropertyName = "PasportSeries";
            this.pasportSeriesDataGridViewTextBoxColumn.HeaderText = "PasportSeries";
            this.pasportSeriesDataGridViewTextBoxColumn.Name = "pasportSeriesDataGridViewTextBoxColumn";
            // 
            // registrationDataGridViewTextBoxColumn
            // 
            this.registrationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.registrationDataGridViewTextBoxColumn.DataPropertyName = "Registration";
            this.registrationDataGridViewTextBoxColumn.HeaderText = "Registration";
            this.registrationDataGridViewTextBoxColumn.Name = "registrationDataGridViewTextBoxColumn";
            // 
            // iDWorkersDataGridViewTextBoxColumn
            // 
            this.iDWorkersDataGridViewTextBoxColumn.DataPropertyName = "IDWorkers";
            this.iDWorkersDataGridViewTextBoxColumn.HeaderText = "IDWorkers";
            this.iDWorkersDataGridViewTextBoxColumn.Name = "iDWorkersDataGridViewTextBoxColumn";
            this.iDWorkersDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientBuffetDataGridViewTextBoxColumn
            // 
            this.clientBuffetDataGridViewTextBoxColumn.DataPropertyName = "ClientBuffet";
            this.clientBuffetDataGridViewTextBoxColumn.HeaderText = "ClientBuffet";
            this.clientBuffetDataGridViewTextBoxColumn.Name = "clientBuffetDataGridViewTextBoxColumn";
            this.clientBuffetDataGridViewTextBoxColumn.Visible = false;
            // 
            // workersDataGridViewTextBoxColumn
            // 
            this.workersDataGridViewTextBoxColumn.DataPropertyName = "Workers";
            this.workersDataGridViewTextBoxColumn.HeaderText = "Workers";
            this.workersDataGridViewTextBoxColumn.Name = "workersDataGridViewTextBoxColumn";
            this.workersDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientsRoomsDataGridViewTextBoxColumn
            // 
            this.clientsRoomsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientsRoomsDataGridViewTextBoxColumn.DataPropertyName = "ClientsRooms";
            this.clientsRoomsDataGridViewTextBoxColumn.HeaderText = "ClientsRooms";
            this.clientsRoomsDataGridViewTextBoxColumn.Name = "clientsRoomsDataGridViewTextBoxColumn";
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.ClientsdataGridView);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsdataGridView;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasportSeriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientBuffetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsRoomsDataGridViewTextBoxColumn;
    }
}