using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();

        }

        private void CleanerButton_Click(object sender, EventArgs e)
        {
            CleanerForm cleanerForm = new CleanerForm();
            this.Hide();
            cleanerForm.ShowDialog();
        }

        private void DirectorButton_Click(object sender, EventArgs e)
        {
            DirectorForm directorForm = new DirectorForm();
            this.Hide();
            directorForm.ShowDialog();
        }
    }
}
