using Lab6new.Controllers;
using Lab6new.RepresentationFactory.Interface;
using OfficeOpenXml;
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
using Lab6new.RepresentationFactory.Representations;
using Lab6new.Controllers.Interface;
using Lab6new.Models.Interface;
using Lab6new.Models;

namespace Lab6new.Forms
{
    internal partial class ExportForm : Form
    {

        private ExportController ExportController { get; }

        public ExportForm(ExportController exportController, List<IExportRepresentation> exportRepresentations)
        {
            ExportRepresentations = exportRepresentations;
            ExportController = exportController;
            InitializeComponent();
        }

        public void SetControllerAndFabric<T>(IExportDataController<T> controller ,
            IRepresentationFabric<T> fabric,Predicate<T> filter, Func<T,bool> sort,bool de)
            where T : class,IModel
        {

        }


        private string folderPath = "";

        private List<IExportRepresentation> ExportRepresentations { get; set; }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExportController.Export(ExportRepresentations, folderPath, fileName.Text);
                MessageBox.Show("Даныне успешно экспортированны", "Сообщение");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void choseFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                pathLabel.Text = folderPath;
            }
        }
    }
}
