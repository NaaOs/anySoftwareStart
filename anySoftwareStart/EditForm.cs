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

namespace anySoftwareStart
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            PathManager.PathList.Clear();
            foreach (var item in PathListBox.Items)
            {
                PathManager.PathAdd(item);
            }
            PathManager.Write();
            
            this.Close();
        }

        private void DeletePath_Click(object sender, EventArgs e)
        {
            PathListBox.Items.Remove(PathListBox.SelectedItem);
        }

        private void NewPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                PathListBox.Items.Add(filePath);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //PathManager.Load();
            foreach (var items in PathManager.PathList)
            {
                PathListBox.Items.Add(items);
            }

        }
    }
}
