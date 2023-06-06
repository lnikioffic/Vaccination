using Lab6new.Controllers;
using Lab6new.Models;
using Lab6new.PermissionManagers;
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
    internal partial class OrganisationForm : RegistriesListForm
    {
        private OrganisationController OrganisationController { get; }

        private LocalityController LocalityController { get; }

        public OrganisationForm(OrganisationController organisationController, LocalityController localityController)
        {
            PermissionManager = organisationController.PermissionManager;
            OrganisationController = organisationController;
            LocalityController = localityController;
            InitializeComponent();
        }

        private List<string> orgTypes = new List<string>
        {
            "Приют",
            "Организация по отлову",
            "Организация по отлову и приют",
            "Организация по транспортировке",
            "Ветеринарная клиника: частная",
            "Благотворительный фонд",
            "Организации по продаже товаров и предоставлению услуг для животных",
            "Исполнительный орган государственной власти",
            "Орган местного самоуправления",
            "Ветеринарная клиника: государственная"
        };

        private void searchButton_Click(object sender, EventArgs e)
        {
            var sorts = GetSorts();
            var sort = sorts[sortBox.Controls.OfType<RadioButton>().First((x => x.Checked))];
            var sortType = descendingRadio.Checked;
            organisationTable.DataSource = OrganisationController
                .GetOrganisationsRepresentation(GetFilters(), sort, sortType)
                .Cast<OrganisationTableRepresentation>()
                .ToList();
        }

        private List<Predicate<Organisation>> GetFilters()
        {
            List<Predicate<Organisation>> filters = new List<Predicate<Organisation>>();

            if (localityFilter.SelectedItem == null)
                filters.Add(organisation => true);
            else
                filters.Add(organisation => organisation.Locality.Locality1 == (localityFilter.SelectedValue as Locality).Locality1);

            if (orgTypeFilter.SelectedItem == null)
                filters.Add(organisation => true);
            else
                filters.Add(organisation => orgTypeFilter.SelectedValue.ToString() == organisation.Type);

            filters.Add(entityBox.GetFilterFromBoolGroupBox((organisation) => (organisation as Organisation).Entity));

            if (innFilter.Text != "")
                filters = new List<Predicate<Organisation>> { (organisation) => organisation.Inn == innFilter.Text };

            return filters;
        }

        private Dictionary<RadioButton, Func<Organisation, object>> GetSorts()
        {
            return new Dictionary<RadioButton, Func<Organisation, object>>
            {
                {fullnameRadio,(x)=>x.FullName},
                {typeRadio,(x)=>x.Type },
                {localityRadio,(x)=>x.Locality.Locality1 },
                {nullSortRadio, (x)=>true }
            };
        }

        private void OrganisationForm_Load(object sender, EventArgs e)
        {
            var localities = LocalityController
                .GetLocalities(new List<Predicate<Locality>>(), (x) => x.Locality1)
                .ToList();

            localityFilter.SetDataToComboBox(localities);

            orgTypeFilter.SetDataToComboBox(orgTypes);
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (organisationTable.SelectedRows.Count == 1)
            {
                var organisationRep = organisationTable.SelectedRows[0].DataBoundItem as OrganisationTableRepresentation;
                if (organisationRep != null)
                {
                    var card = new OrganisationCardForm(
                        organisationRep.RepresentEntity
                    );
                    card.Show();
                }
            }
            else
            {
                MessageBox.Show("Выберете одну строчку!!!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var data = (organisationTable.DataSource as List<OrganisationTableRepresentation>)
                .Select(x => new OrganisationExportRepresentation(x.RepresentEntity))
                .Cast<IExportRepresentation>()
                .ToList();
            var exportForm = new ExportForm(new ExportController(PermissionManager, PermissionManager.User), data);
            exportForm.Show();
        }
    }
}
