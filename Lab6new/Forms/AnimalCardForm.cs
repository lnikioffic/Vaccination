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

        private LocalityController LocalityController { get; }
        private AnimalCardRepresentation AnimalRep { get; set; }
        public AnimalCardForm(AnimalController animalController, LocalityController localityController, Animal animal)
        {
            AnimalController = animalController;
            LocalityController = localityController;
            AnimalRep = animalController
                .GetAnimals(new List<Predicate<Animal>> { (x) => x.Id == animal.Id }, (x) => true)
                .Cast<AnimalCardRepresentation>()
                .First();
            InitializeComponent();
            sex.DataSource = new List<string> { "самец", "самка" };
            category.DataSource = new List<string> { "собака", "кошка" };
        }

        private void AnimalCardForm_Load(object sender, EventArgs e)
        {
            regNumb.Text = AnimalRep.RegistrationNumber;
            category.SelectedItem = AnimalRep.Category;
            sex.SelectedItem = AnimalRep.Sex;
            birthYear.Text = AnimalRep.BirthYear.ToString();
            chipNumb.Text = AnimalRep.ChipNumber;
            name.Text = AnimalRep.Name;
            locality.DataSource = LocalityController
                .GetData(x => x.DistrictId == AnimalRep.Animal.Locality.DistrictId, (x => x.Locality1))
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
            var fields = new Dictionary<string, string>
            {
                {"name",name.Text},
                {"category",category.SelectedItem.ToString()},
                {"sex",sex.SelectedItem.ToString()},
                {"chipNumb",chipNumb.Text},
                {"birthYear",birthYear.Text},
                {"regNumb",regNumb.Text},
                {"specialSigns",specialSigns.Text},
            };
            if (LocalityController.Validate(locality.SelectedItem.ToString()))
            {
                if (AnimalController.Validate(fields))
                {
                    AnimalRep.Animal.RegistrationNumber = fields["regNumb"];
                    AnimalRep.Animal.Category = fields["category"] == "собака";
                    AnimalRep.Animal.Sex = fields["sex"] == "самец";
                    AnimalRep.Animal.Name = fields["name"];
                    AnimalRep.Animal.ChipNumber = fields["chipNumb"];
                    AnimalRep.Animal.BirthYear = int.Parse(fields["birthYear"]);
                    AnimalRep.Animal.SpecialSigns = fields["specialSigns"];
                    AnimalRep.Animal.Locality = LocalityController.GetData(x => x.Locality1 == (locality.SelectedItem.ToString()), (x) => true).First();
                    AnimalRep.Animal.LocalityId = LocalityController.GetData(x => x.Locality1 == (locality.SelectedItem.ToString()), (x) => true).First().Id;
                    AnimalController.CRUDCardController.Update(AnimalRep.Animal);
                    AnimalCardForm_Load(sender, e);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(AnimalRep.Animal.Acts.Count == 0)
            {
                AnimalController.CRUDCardController.Delete(AnimalRep.Animal);
                var message = MessageBox.Show("Животное успешно удалено", "Сообщение");
                this.Close();
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


    }
}
