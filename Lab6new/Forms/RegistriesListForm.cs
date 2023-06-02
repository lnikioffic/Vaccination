using Lab6new.Controllers;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory;
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
        }

        private void animalRegistryButton_Click(object sender, EventArgs e)
        {
            var animalController = new AnimalController(PermissionManager, PermissionManager.User, new TableRepresentationFabric());
            var localityController = new LocalityController(PermissionManager, PermissionManager.User);
            var animalForm = new AnimalForm(animalController,localityController);
            animalForm.Show();
            this.Hide();
        }

        private void contractRegistryButton_Click(object sender, EventArgs e)
        {
            var contractController = new ContractController(PermissionManager, PermissionManager.User);
            var contractForm = new ContractForm(contractController);
            contractForm.Show();
            this.Hide();
        }

        private void organisationRegistryButton_Click(object sender, EventArgs e)
        {
            var organisationController = new OrganisationController(PermissionManager, PermissionManager.User);
            var organisationForm = new OrganisationForm(organisationController);
            organisationForm.Show();
            this.Hide();
        }
    }
}
