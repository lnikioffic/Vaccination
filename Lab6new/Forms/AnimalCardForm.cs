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

        private Animal Animal { get; set; }

        public AnimalCardForm(AnimalController animalController, LocalityController localityController, ActController actController, Animal animal)
        {
            AnimalController = animalController;
            LocalityController = localityController;
            ActController = actController;
            Animal = AnimalController.GetAnimal(animal);
            InitializeComponent();
        }

        private void AnimalCardForm_Load(object sender, EventArgs e)
        {

            regNumb.Text = Animal.RegistrationNumber;
            category.SetDataToComboBox(new List<string> { "собака", "кошка" });
            category.SelectedItem = Animal.Category ? "собака" : "кошка";
            sex.SetDataToComboBox(new List<string> { "самец", "самка" });
            sex.SelectedItem = Animal.Sex ? "самец" : "самка";
            birthYear.Text = Animal.BirthYear.ToString();
            chipNumb.Text = Animal.ChipNumber;
            name.Text = Animal.Name;
            locality.DataSource = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(),
                (x => x.Locality1))
                .Select((x) => x.Locality1)
                .ToList();
            locality.SelectedItem = Animal.Locality.Locality1;
            specialSigns.Text = Animal.SpecialSigns;
            Act? lastAct = Animal.Acts.OrderByDescending(x => x.EndDate).FirstOrDefault();
            actType.Text = lastAct?.Type.ToString();
            actStartDate.Text = lastAct?.StartDate.ToString();
            actEndDate.Text = lastAct?.EndDate.ToString();
            animalPhoto.Image = new Bitmap(Animal.Photo);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Animal.RegistrationNumber = regNumb.Text;
                Animal.Category = category.SelectedItem.ToString() == "собака";
                Animal.Sex = sex.SelectedItem.ToString() == "самец";
                Animal.Name = name.Text;
                Animal.ChipNumber = chipNumb.Text;
                var year = 0;
                int.TryParse(birthYear.Text, out year);
                Animal.BirthYear = year;
                Animal.SpecialSigns = specialSigns.Text;
                Animal.Locality = LocalityController
                    .GetLocalities(new List<Predicate<Locality>> { x => x.Locality1 == locality.SelectedItem.ToString() },
                    (x) => true)
                    .First();
                AnimalController.Update(Animal);
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
                AnimalController.Delete(Animal);
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
                    LocalityController,
                    Animal);
                this.Dispose();
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
                Act? lastAct = Animal.Acts.OrderByDescending(x => x.EndDate).FirstOrDefault();
                if (lastAct != null)
                {
                    var act = ActController.GetAct(lastAct);
                    var actForm = new VaccinationForm(
                    new ActController(AnimalController.PermissionManager,
                        AnimalController.PermissionManager.User),
                    LocalityController,
                    Animal, act);
                    this.Close();
                    actForm.Show();
                }
                else
                {
                    MessageBox.Show("У этго животного нет акта", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}