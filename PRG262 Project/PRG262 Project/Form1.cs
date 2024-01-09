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


namespace PRG262_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       Datahandler handler = new Datahandler();
         Filehandler fh = new Filehandler();
         

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;

            List<Login> UserInfo = handler.ReadToList(fh.FileRead());
            foreach (Login user in UserInfo)
            {
                if (user.Username == txbUsername.Text && user.Password == txbPassword.Text)
                {
                    MessageBox.Show("Login Successful");
                    found = true;
                    Main_Menu main = new Main_Menu();

                    main.Show();
                    this.Hide();

                    break;
                }

            }
            if (found == false)
            {
                DialogResult res;
                res = MessageBox.Show("it looks like you are not registered ,would you like to register yourself ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                
                if (res == DialogResult.Yes)
                {
                    Register registerForm = new Register();
                    registerForm.Show();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
