using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
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
    internal partial class AnimalCardForm : Form
    {
        private AnimalController AnimalController { get; }
        private AnimalCardRepresentation Animal { get; }
        public AnimalCardForm(AnimalController animalController, Animal animal)
        {
            AnimalController = animalController;
            Animal = animalController
                .GetAnimals(new List<Predicate<Animal>> { (x) => x.Id == animal.Id }, (x) => true)
                .Cast<AnimalCardRepresentation>()
                .First();
            InitializeComponent();
        }

        private void AnimalCardForm_Load(object sender, EventArgs e)
        {
            regNumb.Text = Animal.RegistrationNumber;
            category.DataSource = new List<string> { "собака", "кошка" };
            category.SelectedItem = Animal.Category;
            sex.DataSource = new List<string> { "самец", "самка" };
            sex.SelectedItem = Animal.Sex;
            birthYear.Text = Animal.BirthYear.ToString();
            chipNumb.Text = Animal.ChipNumber;
            name.Text = Animal.Name;
            locality.Text = Animal.Locality;
            specialSigns.Text = Animal.SpecialSigns;
            actType.Text = Animal.actType;
            actStartDate.Text = Animal.actStartDate.ToString();
            actEndDate.Text = Animal.actEndDate.ToString();
            animalPhoto.Image = new Bitmap(@Animal.Photo);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void vaccinationButton_Click(object sender, EventArgs e)
        {
            var actForm = new VaccinationForm(
                new ActController(AnimalController.PermissionManager,
                AnimalController.PermissionManager.User),
                Animal.Animal
                );
            actForm.Show();
        }
    }
}
