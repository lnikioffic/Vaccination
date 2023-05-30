using Lab6new.Controllers;
using Lab6new.PermissionManagers;
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
    internal partial class OrganisationForm : RegistriesListForm
    {
        private OrganisationController OrganisationController { get; }

        public OrganisationForm(OrganisationController organisationController)
        {
            PermissionManager = organisationController.PermissionManager;
            OrganisationController = organisationController;
            InitializeComponent();
        }
    }
}
