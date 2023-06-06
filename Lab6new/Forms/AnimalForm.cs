using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.Models.Interface;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
using Lab6new.RepresentationFactory.Representations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab6new.Forms
{
    internal partial class AnimalForm : RegistriesListForm
    {
        private AnimalController AnimalController { get; }

        private LocalityController LocalityController { get; }

        public AnimalForm(AnimalController animalController, LocalityController localityController)
        {
            PermissionManager = animalController.PermissionManager;
            LocalityController = localityController;
            AnimalController = animalController;
            InitializeComponent();
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

            var localities = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(), (x) => x.Locality1)
                .ToList();

            localityFilter.SetDataToComboBox(localities);
        }

        private List<Predicate<Animal>> GetFilters()
        {
            Predicate<Animal> localFil;

            if (localityFilter.SelectedItem == null)
                localFil = (animal) => true;
            else
                localFil = (animal) => animal.Locality.Locality1 == (localityFilter.SelectedValue as Locality).Locality1;

            var filters = new List<Predicate<Animal>>()
            {
                localFil,
                sexFilter.GetFilterFromBoolGroupBox((animal)=>(animal as Animal).Sex),
                categoryFilter.GetFilterFromBoolGroupBox((animal)=>(animal as Animal).Category)
            };
            if (registrationNumberFilter.Text != "")
                filters = new List<Predicate<Animal>> { (animal) => animal.RegistrationNumber == registrationNumberFilter.Text };

            return filters;
        }

        private Dictionary<RadioButton, Func<Animal, object>> GetSorts()
        {
            return new Dictionary<RadioButton, Func<Animal, object>>
            {
                {regNumberRadio,(x)=>x.RegistrationNumber},
                {localityRadio,(x)=>x.Locality.Locality1 },
                {nameRadio,(x)=>x.Name },
                {nullSortRadio, (x)=>true }
            };
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            var sorts = GetSorts();
            var sort = sorts[sortBox.Controls.OfType<RadioButton>().First((x => x.Checked))];
            var sortType = descendingRadio.Checked;
            animalTable.DataSource = AnimalController
                .GetAnimals(GetFilters(), sort, sortType)
                .Cast<AnimalTableRepresentation>()
                .ToList();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (animalTable.SelectedRows.Count == 1)
            {
                var animalRep = animalTable.SelectedRows[0].DataBoundItem as AnimalTableRepresentation;
                if (animalRep != null)
                {
                    var card = new AnimalCardForm(
                    new AnimalController(
                        PermissionManager,
                        PermissionManager.User,
                        new AnimalRepresentationFabric()),
                    new LocalityController(
                        PermissionManager,
                        PermissionManager.User),
                    new ActController(
                        PermissionManager,
                        PermissionManager.User),
                    animalRep.RepresentEntity);
                    card.Show();
                }
            }
            else
            {
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
            }

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var data = (animalTable.DataSource as List<AnimalTableRepresentation>)
                .Select(x => new AnimalExportRepresentation(x.RepresentEntity))
                .Cast<IExportRepresentation>()
                .ToList();
            var exportForm = new ExportForm(new ExportController(PermissionManager, PermissionManager.User), data);
            exportForm.Show();
        }

        private void AnimalForm_Activated(object sender, EventArgs e)
        {
            searchButton_Click(sender, e);
        }
    }

}
