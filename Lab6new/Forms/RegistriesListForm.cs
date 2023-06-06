using Lab6new.Controllers;
using Lab6new.PermissionManagers;
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
    internal partial class RegistriesListForm : Form
    {
        protected IPermissionManager PermissionManager { get; set; }

        public RegistriesListForm()
        {
            InitializeComponent();
        }

        public RegistriesListForm(IPermissionManager permissionManager)
        {
            PermissionManager = permissionManager;
            InitializeComponent();
            username.Text = permissionManager.User.ToString();
        }

        private void animalRegistryButton_Click(object sender, EventArgs e)
        {
            var animalController = new AnimalController(PermissionManager, PermissionManager.User, new AnimalRepresentationFabric());
            var localityController = new LocalityController(PermissionManager, PermissionManager.User);
            var animalForm = new AnimalForm(animalController, localityController);
            animalForm.Show();
            this.Hide();
        }

        private void contractRegistryButton_Click(object sender, EventArgs e)
        {
            var contractController = new ContractController(PermissionManager, PermissionManager.User, new ContractRepresentationFabric());
            var localityController = new LocalityController(PermissionManager, PermissionManager.User);
            var contractForm = new ContractForm(contractController, localityController);
            contractForm.Show();
            this.Hide();
        }

        private void organisationRegistryButton_Click(object sender, EventArgs e)
        {
            var organisationController = new OrganisationController(PermissionManager, PermissionManager.User, new OrganisationRepresentationFabric());
            var localityController = new LocalityController(PermissionManager, PermissionManager.User);
            var organisationForm = new OrganisationForm(organisationController, localityController);
            organisationForm.Show();
            this.Hide();
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {

        }
    }
}
