﻿using System;
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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void WorkersButton_Click(object sender, EventArgs e)
        {
            WorkersForm workersForm = new WorkersForm();
            workersForm.Show();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            CheckRoomsForm checkRoomsForm = new CheckRoomsForm();
            checkRoomsForm.Show();
        }
    }
}
