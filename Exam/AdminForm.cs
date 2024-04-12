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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientsForm clientsform = new ClientsForm();
            clientsform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckRoomsForm checkRoomsForm = new CheckRoomsForm();
            checkRoomsForm.Show();
        }
    }
}
