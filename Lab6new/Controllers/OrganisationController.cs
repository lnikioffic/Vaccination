using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class OrganisationController
    {
        public CRUDCardController<Organisation> CRUDCardController
        {
            get
            {
                if (PermissionManager.CanEditOrganisation())
                    return new CRUDCardController<Organisation>();
                throw new Exception("У вас недостаточно прав");
            }
        }

        public OrganisationController(IPermissionManager permissionManager, User user, IRepresentationFabric<Organisation> representationFabric)
        {
            User = user;
            PermissionManager = permissionManager;
            RepresentationFabric = representationFabric;
        }


        public User User { get; }

        public IPermissionManager PermissionManager { get; }

        private IRepresentationFabric<Organisation> RepresentationFabric { get; }


        public IEnumerable<ITableRepresentation> GetOrganisationsRepresentation(List<Predicate<Organisation>> filters, Func<Organisation, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.OrganisationReadFilter);
            return GetData(resultFilter.GlueFilters(), sort, sortType)
                .Select(
                (x) => RepresentationFabric.CreateTableRepresentation(x)
                );
        }

        public List<Organisation> GetOrganisations(List<Predicate<Organisation>> filters, Func<Organisation, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.OrganisationReadFilter);
            return GetData(resultFilter.GlueFilters(), sort, sortType)
                .ToList();
        }

        public List<Organisation> GetData(Predicate<Organisation> filter, Func<Organisation, object> sort, bool descending = false)
        {
            using (var db = new Lab3newContext())
            {
                var organisations = db.Organisations
                    .Include(x=>x.Locality)
                    .Include(x=>x.ContractPerformOrganisations)
                        .ThenInclude(x=>x.Costs)
                    .Include(x => x.ContractOrderOrganisations)
                        .ThenInclude(x => x.Costs)
                    .AsEnumerable()
                    .Where(x => filter(x))
                    .OrderBy(sort)
                    .AsQueryable();
                if (descending)
                    return organisations.Reverse().ToList();
                return organisations.ToList();
            }
        }
    }
}
