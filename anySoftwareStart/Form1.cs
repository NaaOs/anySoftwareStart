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
using System.Diagnostics;

namespace anySoftwareStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            foreach (var items in PathManager.PathList)
            {
                Process.Start(items);
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var editbuttom = (Button)sender;
            editbuttom.Enabled = false;

            EditForm editForm = new EditForm();
            editForm.ShowDialog(); 

            editbuttom.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PathManager.Load();
        }
    }
}
