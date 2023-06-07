using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using Lab6new.RepresentationFactory.Representations;
using Lab6new.RepresentationFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6new.RepresentationAbstractFactory.Representations;

namespace Lab6new.Forms
{
    internal partial class StatisticForm : RegistriesListForm
    {
        public StatisticController StatisticController { get; set; }

        public StatisticForm(StatisticController statisticController)
        {
            PermissionManager = statisticController.PermissionManager;
            StatisticController = statisticController;
            InitializeComponent();
        }

        private List<Predicate<Act>> GetFilters()
        {
            var interval = new Interval(startDate.Text, endDate.Text);
            return new List<Predicate<Act>> { x => x.StartDate >= interval.StartDate && x.StartDate <= interval.EndDate };
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                statisticTable.DataSource =
                    StatisticController.GetStatistic(
                        GetFilters()
                        )
                    .Cast<StatisticItemTableRepresentation>()
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var data = (statisticTable.DataSource as List<StatisticItemTableRepresentation>)
                .Select(x => new StatisticItemExportRepresentation(x.RepresentEntity))
                .Cast<IExportRepresentation>()
                .ToList();
            var exportForm = new ExportForm(new ExportController(PermissionManager, PermissionManager.User), data);
            exportForm.Show();
        }
    }
}
