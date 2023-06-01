using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.Models.Interface;
using Microsoft.EntityFrameworkCore;
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

            var registrationNumbers = AnimalController
                .GetData((x) => true, (x) => x.RegistrationNumber)
                .Select((x) => x.RegistrationNumber)
                .ToList();

            var chipNumbers = AnimalController
                .GetData((x) => true, (x) => x.ChipNumber)
                .Select((x) => x.ChipNumber)
                .ToList();

            SetDataToComboBox<Locality>(localityFilter, localities);
            SetDataToComboBox<string>(registrationNumberFilter, registrationNumbers);
            SetDataToComboBox<string>(chipNumberFilter, chipNumbers);
        }

        private void SetDataToComboBox<T>(ComboBox comboBox, List<T> data)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DataSource = data;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var filters = new List<Predicate<Animal>>()
            {
                localityFilter.GetFilterFromComboBox((locality) => locality),
                registrationNumberFilter.GetFilterFromComboBox((animal)=> (animal as Animal).RegistrationNumber),
                chipNumberFilter.GetFilterFromComboBox((animal) =>(animal as Animal).ChipNumber),
                sexFilter.GetFilterFromGroupBox((animal)=>(animal as Animal).Sex),
                categoryFilter.GetFilterFromGroupBox((animal)=>(animal as Animal).Category)
            };            
            var filter = AnimalController.And<Animal>(filters);
            var data = AnimalController.GetData(filter, (x) => x.RegistrationNumber);
            animalTable.DataSource = data;
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
        public static Predicate<ICard> GetFilterFromGroupBox(
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
