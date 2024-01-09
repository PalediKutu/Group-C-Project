using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Datahandler handler = new Datahandler();
        Filehandler text = new Filehandler();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mm=new Form1();
            mm.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            List<Login> UserInfo = handler.ReadToList(text.FileRead());
            UserInfo.Add(new Login(txbUsername.Text, txbPassword.Text));
            text.FileWrite(handler.WriteToFile(UserInfo));
        }
    }
}

