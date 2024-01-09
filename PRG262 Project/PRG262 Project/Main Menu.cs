using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG262_Project
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }
        Datahandler handler = new Datahandler();
        Student student = new Student();
        private void btnSD_Click(object sender, EventArgs e)
        {
            Delete sd = new Delete();
            sd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            handler.Add(int.Parse(stdNumber.Text), stdName.Text,stdSurname.Text, dateTimePicker1.Value, genderbox.Text, phoneNo.Text,addressBox.Text, int.Parse(courseBox.Text));
            dataGridView1.DataSource = "";

            /*student.studentImage = ImageToByteArray(PictureBox.Image);

            private byte[] ImageToByteArray(Image image)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
            }*/
            dataGridView1.DataSource = handler.Read();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            handler.Update(int.Parse(stdNumber.Text), stdName.Text, stdSurname.Text, dateTimePicker1.Value, genderbox.Text, phoneNo.Text, addressBox.Text, int.Parse(courseBox.Text));
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = handler.Read();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.Read();
        }
    }
}
