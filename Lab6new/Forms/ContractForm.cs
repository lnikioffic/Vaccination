﻿using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
using Lab6new.RepresentationFactory.Representations;
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
            contractTable.DataSource = ContractController
                .GetContracts(GetFilters(), sort, sortType)
                .Cast<ContractTableRepresentation>()
                .ToList();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (contractTable.SelectedRows.Count == 1)
            {
                var contractRep = contractTable.SelectedRows[0].DataBoundItem as ContractTableRepresentation;
                if (contractRep != null)
                {
                    var card = new ContractCardForm(
                        new LocalityController(PermissionManager, PermissionManager.User),
                        new OrganisationController(PermissionManager, PermissionManager.User, new OrganisationRepresentationFabric()),
                        new ContractController(PermissionManager, PermissionManager.User, new ContractRepresentationFabric()),
                        contractRep.RepresentEntity
                    );
                    card.Show();
                }
            }
            else
            {
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new ContractCardForm(
                new LocalityController(PermissionManager, PermissionManager.User),
                new OrganisationController(PermissionManager, PermissionManager.User, new OrganisationRepresentationFabric()),
                new ContractController(PermissionManager, PermissionManager.User, new ContractRepresentationFabric())
                );
            addForm.Show();
        }

        private void ContractForm_Activated(object sender, EventArgs e)
        {
            searchButton_Click(sender, e);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var data = (contractTable.DataSource as List<ContractTableRepresentation>)
                .Select(x => new ContractTableRepresentation(x.RepresentEntity))
                .Cast<IExportRepresentation>()
                .ToList();
            var exportForm = new ExportForm(new ExportController(PermissionManager, PermissionManager.User), data);
            exportForm.Show();
        }
    }
}