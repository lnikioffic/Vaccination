using Lab6new.Controllers;
using Lab6new.Models;
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
    internal partial class ContractForm : RegistriesListForm
    {
        private ContractController ContractController { get; }

        private LocalityController LocalityController { get; }

        public ContractForm(ContractController contractController, LocalityController localityController)
        {
            PermissionManager = contractController.PermissionManager;
            ContractController = contractController;
            LocalityController = localityController;
            InitializeComponent();
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            var localities = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(), (x) => x.Locality1)
                .ToList();

            localityFilter.SetDataToComboBox(localities);
        }

        private List<Predicate<Contract>> GetFilters()
        {
            Predicate<Contract> filter;

            if (localityFilter.SelectedItem == null)
                filter = (contract) => true;
            else
                filter = (contract) => contract.Costs.Select(x => x.Locality.Locality1)
                .Contains((localityFilter.SelectedValue as Locality).Locality1);

            if (orderOrgFilter.Text != "")
                filter = (contract) => contract.OrderOrganisation.FullName == orderOrgFilter.Text;

            if (performOrgFilter.Text != "")
                filter = (contract) => contract.PerformOrganisation.FullName == orderOrgFilter.Text;

            return new List<Predicate<Contract>> { filter };
        }

        private Dictionary<RadioButton, Func<Contract, object>> GetSorts()
        {
            return new Dictionary<RadioButton, Func<Contract, object>>
            {
                {startDateRadio,(x)=>x.StartDate},
                {endDateRadio,(x)=>x.EndDate },
                {costRadio,(x)=>x.Costs.Select(x=>x.Cost1).Average() },
                {nullSortRadio, (x)=>true }
            };
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var sorts = GetSorts();
            var sort = sorts[sortBox.Controls.OfType<RadioButton>().First((x => x.Checked))];
            var sortType = descendingRadio.Checked;
            animalTable.DataSource = ContractController
                .GetContracts(GetFilters(), sort, sortType)
                .Cast<ContractTableRepresentation>()
                .ToList();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new ContractAddForm(
                new LocalityController(PermissionManager, PermissionManager.User),
                new OrganisationController(PermissionManager, PermissionManager.User, new CardRepresentationFabric()),
                new ContractController(PermissionManager, PermissionManager.User, new CardRepresentationFabric()),
                new CostController(PermissionManager, PermissionManager.User)
                );
            addForm.Show();
        }


    }
}
