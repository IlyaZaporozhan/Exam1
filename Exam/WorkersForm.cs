using Exam.Helper;
using Exam.ModelEF;
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
    public partial class WorkersForm : Form
    {
        private Model1 ef = new Model1();
        public WorkersForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = DBHelper.db.Workers.ToList();
        }
      
    }
}
