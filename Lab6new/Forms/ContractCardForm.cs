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
    internal partial class ContractCardForm : Form
    {
        private LocalityController LocalityController { get; }

        private OrganisationController OrganisationController { get; }

        private ContractController ContractController { get; }        

        public ContractCardForm(LocalityController localityController,
            OrganisationController organisationController,
            ContractController contractController)
        {
            LocalityController = localityController;
            OrganisationController = organisationController;
            ContractController = contractController;
            InitializeComponent();
        }

        public ContractCardForm(LocalityController localityController,
            OrganisationController organisationController,
            ContractController contractController, Contract contract)
        {
            LocalityController = localityController;
            OrganisationController = organisationController;
            ContractController = contractController;
            Contract = contract;
            InitializeComponent();
        }

        private Contract? Contract { get; set; }

        private void ContractCardForm_Load(object sender, EventArgs e)
        {
            var localities = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(), (x) => x.Locality1);

            var orderOrganisation = OrganisationController
                .GetOrganisations(new List<Predicate<Organisation>>(), x => x.FullName)
                .Select(x => x.FullName)
                .ToList();

            var performOrganisation = OrganisationController
                .GetOrganisations(new List<Predicate<Organisation>>(), x => x.FullName)
                .Select(x => x.FullName)
                .ToList();

            localityCombobox.SetDataToComboBox(localities);
            orderOrgCombobox.SetDataToComboBox(orderOrganisation);
            performOrgComboBox.SetDataToComboBox(performOrganisation);

            if (Contract != null)
            {
                deleteButton.Visible = true;
                updateButton.Visible = true;
                contractAddButton .Visible = false;
                SetFieldsValues(Contract);
            }
            else
            {
                deleteButton.Visible = false;
                updateButton.Visible = false;
                contractAddButton.Visible = true;
            }


        }

        private void SetFieldsValues(Contract contract)
        {
            numbTextBox.Text = contract.Number.ToString();
            orderOrgCombobox.SelectedItem = contract.OrderOrganisation.FullName;
            performOrgComboBox.SelectedItem = contract.PerformOrganisation.FullName;
            startDate.Text = contract.StartDate.ToString();
            endDate.Text = contract.EndDate.ToString();
            foreach (var cost in Contract.Costs)
                CreateCostsControls(cost.Locality.Locality1, cost.Cost1.ToString());
        }

        private Dictionary<Button, Tuple<Label, Label>> costsControls = new Dictionary<Button, Tuple<Label, Label>>();

        private Dictionary<Button, Tuple<Label, Label>> CostsControls
        {
            get { return costsControls; }

            set
            {
                costsControls = value;
                DrawTable();
            }
        }
        private Organisation OrderOrganisation
        {
            get
            {
                return OrganisationController
                    .GetOrganisations(
                    new List<Predicate<Organisation>> { x => x.FullName == orderOrgCombobox.SelectedItem.ToString() },
                    x => true)
                    .First();
            }
        }


        private List<Cost> CreateCosts(Contract contract)
        {
            var list = new List<Cost>();
            var price = 0;
            foreach (var cost in CostsControls.Values)
            {
                int.TryParse(cost.Item2.Text, out price);
                var locality = LocalityController
                    .GetLocalities(
                    new List<Predicate<Locality>> { x => x.Locality1 == cost.Item1.Text },
                    x => true
                    ).First();
                list.Add(
                    new Cost
                    {
                        ContractId = contract.Id,
                        LocalityId = locality.Id,
                        Cost1 = price
                    }
                    );
            }
            return list;

        }

        private Organisation PerformOrganisation
        {
            get
            {
                return OrganisationController
                    .GetOrganisations(
                    new List<Predicate<Organisation>> { x => x.FullName == performOrgComboBox.SelectedItem.ToString() },
                    x => true)
                    .First();
            }
        }

        private void CreateCostsControls(string locality, string cost)
        {
            var delButton = new Button { Name = "deleteButton" + CostsControls.Count, Text = "X" };
            delButton.Click += (s, e) => deleteCostButton_Click(s, e);
            var costsTable = CostsControls;
            costsTable.Add(
                delButton,
                Tuple.Create(
                    new Label { Name = "localityLabel" + CostsControls.Count, Text = locality },
                    new Label { Name = "priceLabel" + CostsControls.Count, Text = cost }
                    )
                );

            CostsControls = costsTable;
        }

        private void addLocalityButton_Click(object sender, EventArgs e)
        {
            var locality = localityCombobox.SelectedItem == null ? "" : localityCombobox.SelectedItem.ToString();
            if (LocalityController.Validate(locality))
            {
                var price = 0;
                if (int.TryParse(costTextBox.Text, out price))
                {
                    if (CheckUniqueLocality(locality))
                    {
                        CreateCostsControls(locality, costTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show(locality + " уже добавлен", "Ошибка");
                    }

                }
            }
            localityCombobox.SelectedItem = null;
            costTextBox.Text = "";
        }

        private bool CheckUniqueLocality(string locality)
        {
            foreach (var costs in CostsControls.Values)
                if (costs.Item1.Text == locality)
                    return false;
            return true;
        }

        private void DrawTable()
        {
            var previous = this.Controls.OfType<TableLayoutPanel>().Where(x => x.ColumnCount == 3).First();
            this.Controls.Remove(previous);
            var table = new TableLayoutPanel { Location = new Point(458, 53), ColumnCount = 3, AutoSize = true, RowCount = 1 };
            this.Controls.Add(table);
            foreach (var costControl in costsControls)
            {
                table.RowCount++;
                var row = table.RowCount - 1;
                table.Controls.Add(costControl.Value.Item1, 0, row);
                table.Controls.Add(costControl.Value.Item2, 1, row);
                table.Controls.Add(costControl.Key, 2, row);

            }
        }

        private void deleteCostButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var costsTable = CostsControls;
            costsTable.Remove(button);
            CostsControls = costsTable;
        }

        private void contractAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var interval = new Interval(startDate.Text, endDate.Text);
                var contract = new Contract
                {
                    Number = numbTextBox.Text,
                    StartDate = interval.StartDate,
                    EndDate = interval.EndDate,
                    OrderOrganisationId = OrderOrganisation.Id,
                    PerformOrganisationId = PerformOrganisation.Id,
                };
                contract.Costs = CreateCosts(contract);
                ContractController.Add(contract,PerformOrganisation);
                MessageBox.Show("Контракт успешно добавлен", "Сообщение");
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ContractController.Delete(Contract);
                MessageBox.Show("Контракт успешно удален", "Сообщение");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var interval = new Interval(startDate.Text,endDate.Text);
                Contract.Number = numbTextBox.Text;
                Contract.PerformOrganisation = PerformOrganisation;
                Contract.OrderOrganisation = OrderOrganisation;
                Contract.StartDate = interval.StartDate;
                Contract.EndDate = interval.EndDate;
                Contract.Costs = CreateCosts(Contract);
                ContractController.Update(Contract,PerformOrganisation);
                MessageBox.Show("Контракт успешно изменен", "Сообщение");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
