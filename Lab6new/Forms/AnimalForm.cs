using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.Models.Interface;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
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
                .GetData((x) => true, (x) => x.Locality1)
                .ToList();

            SetDataToComboBox(localityFilter, localities);
        }

        private void SetDataToComboBox<T>(ComboBox comboBox, List<T> data)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DataSource = data;
            comboBox.SelectedItem = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
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

            var sorts = new Dictionary<RadioButton, Func<Animal, object>>
            {
                {regNumberRadio,(x)=>x.RegistrationNumber},
                {localityRadio,(x)=>x.Locality.Locality1 },
                {nameRadio,(x)=>x.Name },
                {nullSortRadio, (x)=>true }
            };

            if (registrationNumberFilter.Text != "")
                filters = new List<Predicate<Animal>> { (animal) => animal.RegistrationNumber == registrationNumberFilter.Text };

            var sort = sorts[sortBox.Controls.OfType<RadioButton>().First((x => x.Checked))];

            var sortType = descendingRadio.Checked;

            animalTable.DataSource = AnimalController
                .GetAnimals(filters, sort, sortType)
                .Cast<AnimalTableRepresentation>()
                .ToList();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (animalTable.SelectedRows.Count == 1)
            {
                var card = new AnimalCardForm(
                    new AnimalController(
                        PermissionManager,
                        PermissionManager.User,
                        new CardRepresentationFabric()
                        ),(animalTable.SelectedRows[0].DataBoundItem as AnimalTableRepresentation).Animal
                    );
                card.Show();
            }
            else
            {
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
            }

        }
    }

    internal static class Extensions
    {
        public static Predicate<ICard> GetFilterFromComboBox(
            this ComboBox comboBox, Func<ICard, object> selector
            )
        {
            if (comboBox.SelectedValue == null)
                return (x) => true;
            return (x) => selector(x).ToString() == comboBox.SelectedValue.ToString();
        }
        public static Predicate<ICard> GetFilterFromBoolGroupBox(
            this GroupBox groupBox, Func<ICard, bool> selector
            )
        {

            var checkBoxes = groupBox.Controls.OfType<CheckBox>().ToArray();

            if (checkBoxes[0].Checked == checkBoxes[1].Checked)
                return (x) => checkBoxes[0].Checked && checkBoxes[1].Checked;

            return (x) => selector(x) == checkBoxes[0].Checked;
        }

        /*
         В БД
         собака = true
         кошка = false
        --------------
        если собака = flase и кошка = false (x)=>false
        если собака = true и кошка = true (x)=>true
        --------------
        если собака = true и кошка = false (x)=>x.Category = true
        если собака = false и кошка = true (x)=>x.Category = false
         */
    }
}
