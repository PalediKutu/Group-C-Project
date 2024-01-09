using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Project
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void sdExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            MessageBox.Show("Exited");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.studentID = int.Parse(searchtbcx.Text);

            Datahandler handler = new Datahandler();
            dataGridView1.DataSource = handler.Search(student.studentID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.studentID = int.Parse(searchtbcx.Text);

            Datahandler handler = new Datahandler();
            handler.Search(student.studentID);
        }
    }
}
