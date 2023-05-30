using Lab6new.Controllers;
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
                .GetData((x) => true)
                .Select(x => x.Locality1)
                .ToArray();

            localityFilter.Items.AddRange(localities);
        }

        private void localityFilter_TextChanged(object sender, EventArgs e)
        {
            localityFilter.Items.Clear();
        }
    }
}
