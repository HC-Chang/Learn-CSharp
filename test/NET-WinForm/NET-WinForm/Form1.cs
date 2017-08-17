using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace NET_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> l_paths = new List<string>();
        string temp ;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;
            // ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; ;

            ofd.ShowDialog();

            for(int i =0;i< ofd.FileNames.Length ;i++ )
            {
                if( File.Exists(ofd.FileNames[i]))
                {
                    comboBox1.Items.Add(ofd.SafeFileNames[i]);
                    l_paths.Add(ofd.FileNames[i]);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            
            MessageBox.Show("Finish", "通知");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = "";
            StreamReader sr;
            
            for(int i =0; i<l_paths.Count;i++)
            {
                sr = new StreamReader(l_paths[i]);
                temp += string.Format("{0}\n", sr.ReadToEnd());
                sr.Close();
            }

            MessageBox.Show(temp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("123.txt");
            sw.Write(temp);
            sw.Close();

            MessageBox.Show("Finish");
        }
    }
}
