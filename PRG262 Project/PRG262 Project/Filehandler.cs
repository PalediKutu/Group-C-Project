using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Project
{
    internal class Filehandler
    {
        

       
        
            public List<string> FileRead()
            {
                List<string> info = new List<string>();
                string path = "Files\\usernames.txt";
                try
                {
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    fs.Close();
                    if (File.ReadAllLines(path) != null)
                    {
                        info = File.ReadAllLines(path).ToList();
                        
                    }
                    else
                    {
                        MessageBox.Show("your data wasn't stored");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                return info;
            }
            public void FileWrite(List<string> info)
            {
                string path = "Files\\usernames.txt"; 
                try
                {
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    fs.Close();
                    File.WriteAllLines(path, info);
                    MessageBox.Show("you have been registered, now you can login");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }


