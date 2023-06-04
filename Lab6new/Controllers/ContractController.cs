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

        public ContractController(IPermissionManager permissionManager, User user, IRepresentationFabric representationFabric)
        {
            User = user;
            PermissionManager = permissionManager;
            RepresentationFabric = representationFabric;
        }


        public User User { get; }

        public IPermissionManager PermissionManager { get; }

        private IRepresentationFabric RepresentationFabric { get; }

        public bool Validate(Contract contract)
        {
            /*var notEmptyField = animal.Name != "" && animal.SpecialSigns != ""
                && animal.RegistrationNumber != "" && animal.ChipNumber != "";
            var uniqueField = GetData((x) => (x.RegistrationNumber == animal.RegistrationNumber
            || x.ChipNumber == animal.ChipNumber) && x.Id != animal.Id, (x) => true)
                .FirstOrDefault() == null;
            var inputField = animal.BirthYear != 0;
            return notEmptyField && uniqueField && inputField;*/
            return true;
        }

        public void Update(Contract contract)
        {
            if (Validate(contract))
                CRUDCardController.Update(contract);
            else
                throw new Exception("Не верно введеные данные");
        }

        public void Delete(Contract contract)
        {
            if (contract.Acts.Count == 0)
                CRUDCardController.Delete(contract);
            else
                throw new Exception("Нельзя удалять животное, у которго есть акты вакцинации");
        }

        public IEnumerable<IContractRepresentation> GetContracts(List<Predicate<Contract>> filters, Func<Contract, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.ContractReadFilter);
            return GetData(resultFilter.GlueFilters(), sort, sortType)
                .Select(
                (x) => RepresentationFabric
                .createContractRepresentation(x)
                );
        }

        public List<Contract> GetData(Predicate<Contract> filter, Func<Contract, object> sort, bool descending = false)
        {
            using (var db = new Lab3newContext())
            {
                var contracts = db.Contracts
                    .Include(x => x.OrderOrganisation)
                    .Include(x => x.PerformOrganisation)
                        .ThenInclude(x=>x.Locality)
                    .Include(x=>x.Costs)
                        .ThenInclude(x=>x.Locality)
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
