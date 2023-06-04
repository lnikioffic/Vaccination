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
using Lab6new.Models;

namespace Lab6new.Forms
{
    internal partial class ContractAddForm : Form
    {
        private LocalityController LocalityController { get; }

        private OrganisationController OrganisationController { get; }

        private ContractController ContractController { get; }

        private CostController CostController { get; }

        public ContractAddForm(LocalityController localityController,
            OrganisationController organisationController,
            ContractController contractController, CostController costController)
        {
            LocalityController = localityController;
            OrganisationController = organisationController;
            ContractController = contractController;
            CostController = costController;
            InitializeComponent();
        }

        private void ContractCardForm_Load(object sender, EventArgs e)
        {
            var localities = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(), (x) => x.Locality1);

            var organisation = OrganisationController
                .GetOrganisations1(new List<Predicate<Organisation>>(), x => x.FullName)
                .ToList();

            localityCombobox.SetDataToComboBox(localities);
            orderOrgCombobox.SetDataToComboBox(organisation);
            performOrgComboBox.SetDataToComboBox(organisation);
        }
        private Dictionary<Button, Tuple<Label, Label>> CostsControls = new Dictionary<Button, Tuple<Label, Label>>();
        private void addLocalityButton_Click(object sender, EventArgs e)
        {
            if (LocalityController.Validate(localityCombobox.SelectedItem.ToString()))
            {
                var price = 0;
                if (int.TryParse(costTextBox.Text, out price))
                {
                    CostsControls.Add(
                        new Button { Name = "deleteButton" + CostsControls.Count },
                        Tuple.Create(
                            new Label { Name = "localityLabel" + CostsControls.Count, Text = localityCombobox.SelectedItem.ToString() },
                            new Label { Name = "priceLabel" + CostsControls.Count, Text = costTextBox.Text }
                            )
                        );
                }
            }
        }
        private void deleteCostButton_Click(object sender, EventArgs e)
        {

        }
    }
}
