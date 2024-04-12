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
    public partial class CheckRoomsForm : Form
    {
        private Model1 ef = new Model1();

        public CheckRoomsForm()
        {
            InitializeComponent();
            PrepareData();
        }

        public void PrepareData()
        {
            var rooms = ef.Rooms.ToList();


        }
    }
}
