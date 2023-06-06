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
    internal class ContractController
    {
        public CRUDCardController<Contract> CRUDCardController
        {
            get
            {
                if (PermissionManager.CanEditContract())
                    return new CRUDCardController<Contract>();
                throw new Exception("У вас недостаточно прав");
            }
        }

        private CostController CostController { get; }

        public ContractController(IPermissionManager permissionManager, User user, IRepresentationFabric<Contract> representationFabric)
        {
            User = user;
            PermissionManager = permissionManager;
            RepresentationFabric = representationFabric;
            CostController = new CostController(PermissionManager, User);
        }


        public User User { get; }

        public IPermissionManager PermissionManager { get; }

        private IRepresentationFabric<Contract> RepresentationFabric { get; }

        public void Validate(Contract contract,Organisation peformOrg)
        {
            var errors = new List<string>();
            if (contract.Number == "")
                errors.Add("Номер не может быть путсым.");

            if (GetData((x) => (x.Number == contract.Number) && x.Id != contract.Id, (x) => true)
                .FirstOrDefault() != null)
                errors.Add("Поле номер должно быть уникальным");

            if (peformOrg
                    .ContractPerformOrganisations
                    .Where(x => x.EndDate >= DateOnly.FromDateTime(DateTime.Now))
                    .Count() != 0)
                errors.Add("Организация " + peformOrg.ToString() + " уже имеет действующий контракт");

            if (contract.PerformOrganisationId == contract.OrderOrganisationId)
                errors.Add("Организация закказчика и исполнителя не могут совпадать");

            if(contract.Costs.Select(x=>x.Locality.DistrictId).Where(x=>x != peformOrg.Locality.DistrictId).Count()>0)
                errors.Add("Исполнитель не может вакцинировать, во всех городах из списка");

            if (errors.Count > 0)
                throw new ArgumentException(String.Join("\n", errors));
        }


        public void Delete(Contract contract)
        {
            if (contract.Acts.Count == 0)
            {
                CRUDCardController.Delete(contract);
            }
            else
                throw new Exception("Нельзя удалять контракт по каторому выполнена хотябы одна вакцинация");
        }

        public void Add(Contract contract,Organisation peformOrg)
        {
            Validate(contract, peformOrg);
            CRUDCardController.Add(contract);
        }

        public IEnumerable<ITableRepresentation> GetContracts(List<Predicate<Contract>> filters, Func<Contract, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.ContractReadFilter);
            return GetData(resultFilter.GlueFilters(), sort, sortType)
                .Select(
                (x) => RepresentationFabric
                .CreateTableRepresentation(x)
                );
        }

        private void CheckPermissons()
        {
            if (!PermissionManager.CanEditContract())
                throw new Exception("У вас недостаточно прав");
        }
        public void Update(Contract contract, Organisation peformOrg)
        {
            CheckPermissons();
            Validate(contract, peformOrg);
            using (var db = new Lab3newContext())
            {
                var contr = db.Contracts.Single(x => x.Id == contract.Id);
                contr.StartDate = contract.StartDate;
                contr.EndDate = contract.EndDate;
                contr.Number = contract.Number;
                contr.OrderOrganisation
                    = db.Organisations.Single(x => x.Id == contract.OrderOrganisation.Id);
                contr.PerformOrganisation =
                    db.Organisations.Single(x => x.Id == contract.PerformOrganisation.Id);
                contr.Costs = null;
                db.SaveChanges();
                contr.Costs = contract.Costs;
                db.SaveChanges();
            }
        }

        public List<Contract> GetData(Predicate<Contract> filter, Func<Contract, object> sort, bool descending = false)
        {
            using (var db = new Lab3newContext())
            {
                var contracts = db.Contracts
                    .Include(x => x.OrderOrganisation)
                    .Include(x => x.PerformOrganisation)
                        .ThenInclude(x => x.Locality)
                    .Include(x => x.PerformOrganisation)
                        .ThenInclude(x => x.ContractPerformOrganisations)
                    .Include(x => x.Costs)
                        .ThenInclude(x => x.Locality)
                    .AsEnumerable()
                    .Where(x => filter(x))
                    .OrderBy(sort)
                    .AsQueryable();
                if (descending)
                    return contracts.Reverse().ToList();
                return contracts.ToList();
            }
        }
    }
}
