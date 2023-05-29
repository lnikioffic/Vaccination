using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    internal class OMSUOperatorPermissionManager : IPermissionManager
    {

        private List<string> accessOrganisationType = new List<string>()
        {
            "Приют",
            "Организация по отлову",
            "Организация по отлову и приют",
            "Организация по транспортировке",
            "Ветеринарная клиника: государственная",
            "Ветеринарная клиника: частная",
            "Благотворительный фонд",
            "Организации по продаже товаров и предоставлению услуг для животных"
        };

        public OMSUOperatorPermissionManager(User user)
        {
            User = user;
        }
        public User User { get; }

        public Predicate<Animal> AnimalReadFilter
            => (animal) => animal.Locality.DistrictId == User.Organisation.Locality.DistrictId;

        public Predicate<Act> ActReadFilter
            => (act) => act.Locality.DistrictId == User.Organisation.Locality.DistrictId;

        public Predicate<Contract> ContractReadFilter
            => (contract) => contract.Costs
            .Select((cost) => cost.LocalityId)
            .Contains(User.Organisation.LocalityId);

        public Predicate<Organisation> OrganisationReadFilter
            => (organisation) => organisation.Locality.DistrictId == User.Organisation.Locality.DistrictId
            && accessOrganisationType.Contains(organisation.Type);

        public bool CanEditAct() => false;

        public bool CanEditAnimal() => false;

        public bool CanEditContract() => true;

        public bool CanEditOrganisation() => true;
    }
}
