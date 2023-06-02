using Lab6new.Controllers;
using Lab6new.Models;
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
            Animal = animal;
            user = ActController.User;
            InitializeComponent();

        }
        private User user;

        private ActController ActController { get; }

        private Animal Animal { get; }

        private void VaccinationForm_Load(object sender, EventArgs e)
        {
            animal.Text = Animal.ToString();
            doctor.Text = user.ToString();
            contract.Text = user
                .Organisation
                .ContractPerformOrganisations
                .OrderByDescending((x) => x.EndDate)
                .First()
                .ToString();
            locality.Text = user.Organisation.Locality.ToString();
            startDate.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActController.PermissionManager.CanEditAct())
                if (ActController.Validate(duration.Text, type.Text, serialNumb.Text))
                {
                    var act =new Act
                    {
                        AnimalId = Animal.Id,
                        UserId = user.Id,
                        StartDate = DateOnly.FromDateTime(DateTime.Now),
                        EndDate = DateOnly.FromDateTime(DateTime.Now).AddDays(int.Parse(duration.Text)),
                        Type = type.Text,
                        SerialNumber = serialNumb.Text,
                        LocalityId = user.Organisation.Locality.Id,
                        ContractId = user.Organisation
                        .ContractPerformOrganisations
                        .OrderByDescending((x) => x.EndDate).First().Id
                    };
                    ActController.CRUDCardController.Add(act);
                }

        }
    }
}
