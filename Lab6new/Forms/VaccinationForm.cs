using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory;
using Microsoft.VisualBasic.ApplicationServices;
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
    internal partial class VaccinationForm : Form
    {
        public VaccinationForm(ActController actController, Animal animal)
        {
            ActController = actController;
            if (animal.Acts.Where((x) => x.EndDate > DateOnly.FromDateTime(DateTime.Now)).FirstOrDefault() == null)
                this.animal = animal;
            else
                throw new ArgumentException("У этого животного еще действует вакцина");
            user = ActController.User;
            organisation = user.Organisation;
            locality = organisation.Locality;
            contract = organisation
                .ContractPerformOrganisations
                .OrderByDescending((x) => x.EndDate)
                .First();
            InitializeComponent();
        }

        private User user;

        private Organisation organisation;

        private Locality locality;

        private Contract contract;

        private ActController ActController { get; }

        private Animal animal;

        private void VaccinationForm_Load(object sender, EventArgs e)
        {
            animalTextBox.Text = animal.ToString();
            userTextBox.Text = user.ToString();
            contractTextBox.Text = contract.ToString();
            localityTextBox.Text = locality.ToString();
            startDateTextBox.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActController.PermissionManager.CanEditAct())
            {
                if (ActController.Validate(durationTextBox.Text, typeTextBox.Text, serialNumbTextBox.Text))
                {
                    var act = new Act
                    {
                        AnimalId = animal.Id,
                        UserId = user.Id,
                        StartDate = DateOnly.FromDateTime(DateTime.Now),
                        EndDate = DateOnly.FromDateTime(DateTime.Now).AddDays(int.Parse(durationTextBox.Text)),
                        Type = typeTextBox.Text,
                        SerialNumber = serialNumbTextBox.Text,
                        LocalityId = locality.Id,
                        ContractId = contract.Id
                    };
                    ActController.CRUDCardController.Add(act);
                    var message = MessageBox.Show("Животное успешно вакцинировано", "Сообщение", MessageBoxButtons.OK);
                    if (message == DialogResult.OK)
                    {
                        this.Close();
                        var card = new AnimalCardForm(
                            new AnimalController(
                                ActController.PermissionManager,
                                ActController.User,
                                new CardRepresentationFabric()),
                            new LocalityController(
                                ActController.PermissionManager,
                                ActController.User),
                            animal);
                        card.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Неверно заполненые поля", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("У вас нет прав,аххахахах", "Ошибка", MessageBoxButtons.OK);
            }


        }

        private void VaccinationForm_Activated(object sender, EventArgs e)
        {

        }
    }
}
