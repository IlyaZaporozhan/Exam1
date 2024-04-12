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
    public partial class WorkersUserControl : UserControl
    {
        private Workers _worker;
        
        public WorkersUserControl(Workers workers, Roles roles)
        {
            InitializeComponent();
            _worker = workers;
            Fill(workers);
            
        }
        public void Fill(Workers workers)
        {
            var model1 = new Model1();
            FullNameLabel.Text = _worker.FullName.ToString();
            WorkerPictureBox.Image = Image.FromFile (string.IsNullOrEmpty(_worker.Photo) ? @"WorkersPhoto\placeholder.png" : _worker.Photo);
            //var roles = model1.Workers.Where(pm => pm.IDRole == )
        }
        private void WorkersUserControl_Load(object sender, EventArgs e)
        {
           
        }
    }
}
