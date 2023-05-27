using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Auth.PermissionManagers
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
            => (x) => x.LocalityId == User.Organisation.LocalityId;

        public Predicate<Act> ActReadFilter
            => (x) => x.LocalityId == User.Organisation.LocalityId;

        public Predicate<Contract> ContractReadFilter
            => (x) => x.Costs
            .Select((y) => y.LocalityId)
            .Contains(User.Organisation.LocalityId);

        public Predicate<Organisation> OrganisationReadFilter
            => (x) => x.LocalityId == User.Organisation.LocalityId
            && accessOrganisationType.Contains(x.Type);

        public bool CanEditAct() => false;

        public bool CanEditAnimal()=> false;

        public bool CanEditContract()=> true;

        public bool CanEditOrganisation() => true;
    }
}
