using Lab6new.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6new.Forms
{
    public partial class ExportForm : Form
    {
        
        private ExportController ExportController { get { return new ExportController(); } }

        public ExportForm()
        {
            InitializeComponent();
        }

        /*private ExportData*/

        private void exportButton_Click(object sender, EventArgs e)
        {
            
        }

        private void choseFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var folderName = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
