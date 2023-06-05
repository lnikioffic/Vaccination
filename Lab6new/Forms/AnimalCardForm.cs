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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6new.Forms
{
    internal partial class AnimalCardForm : Form
    {
        private AnimalController AnimalController { get; }

        private LocalityController LocalityController { get; }

        private ActController ActController { get; }
        private AnimalCardRepresentation AnimalRep { get; set; }

        public AnimalCardForm(AnimalController animalController, LocalityController localityController, ActController actController, Animal animal)
        {
            AnimalController = animalController;
            LocalityController = localityController;
            ActController = actController;
            AnimalRep = animalController
                .GetAnimals(new List<Predicate<Animal>> { (x) => x.Id == animal.Id }, (x) => true)
                .Cast<AnimalCardRepresentation>()
                .First();
            InitializeComponent();
        }

        private void AnimalCardForm_Load(object sender, EventArgs e)
        {

            regNumb.Text = AnimalRep.RegistrationNumber;
            category.SetDataToComboBox(new List<string> { "собака", "кошка" });
            category.SelectedItem = AnimalRep.Category;
            sex.SetDataToComboBox(new List<string> { "самец", "самка" });
            sex.SelectedItem = AnimalRep.Sex;
            birthYear.Text = AnimalRep.BirthYear.ToString();
            chipNumb.Text = AnimalRep.ChipNumber;
            name.Text = AnimalRep.Name;
            locality.DataSource = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(),
                (x => x.Locality1))
                .Select((x) => x.Locality1)
                .ToList();
            locality.SelectedItem = AnimalRep.Locality;
            specialSigns.Text = AnimalRep.SpecialSigns;
            actType.Text = AnimalRep.actType;
            actStartDate.Text = AnimalRep.actStartDate.ToString();
            actEndDate.Text = AnimalRep.actEndDate.ToString();
            animalPhoto.Image = new Bitmap(AnimalRep.Photo);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalRep.Animal.RegistrationNumber = regNumb.Text;
                AnimalRep.Animal.Category = category.SelectedItem.ToString() == "собака";
                AnimalRep.Animal.Sex = sex.SelectedItem.ToString() == "самец";
                AnimalRep.Animal.Name = name.Text;
                AnimalRep.Animal.ChipNumber = chipNumb.Text;
                var year = 0;
                int.TryParse(birthYear.Text, out year);
                AnimalRep.Animal.BirthYear = year;
                AnimalRep.Animal.SpecialSigns = specialSigns.Text;
                AnimalRep.Animal.Locality = LocalityController
                    .GetLocalities(new List<Predicate<Locality>> { x => x.Locality1 == locality.SelectedItem.ToString() },
                    (x) => true)
                    .First();
                AnimalController.Update(AnimalRep.Animal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            AnimalCardForm_Load(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnimalController.Delete(AnimalRep.Animal);
                MessageBox.Show("Животное успешно удаленно", "Сообщение");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void vaccinationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var actForm = new VaccinationForm(
                    new ActController(AnimalController.PermissionManager,
                        AnimalController.PermissionManager.User),
                    AnimalRep.Animal);
                this.Close();
                actForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void actChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AnimalRep.lastAct != null)
                {
                    var act = ActController.GetActs(new List<Predicate<Act>> { (x) => x.Id == AnimalRep.lastAct.Id }, (x) => true).First();
                    var actForm = new VaccinationForm(
                    new ActController(AnimalController.PermissionManager,
                        AnimalController.PermissionManager.User),
                    AnimalRep.Animal, act);
                    this.Close();
                    actForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
