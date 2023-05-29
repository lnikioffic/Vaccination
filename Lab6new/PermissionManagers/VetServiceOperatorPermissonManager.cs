using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    internal class VetServiceOperatorPermissonManager:IPermissionManager
    {
        //Оператор Ветслужбы
        private List<string> accessOrganisationType
            = new List<string>()
        {
            "Исполнительный орган государственной власти",
            "Орган местного самоуправления",
            "Ветеринарная клиника: государственная"
        };

        public VetServiceOperatorPermissonManager(User user)
        {
            User = user;
        }

        public User User { get; }

        public Predicate<Animal> AnimalReadFilter
            => (animal) => true;

        public Predicate<Act> ActReadFilter
            => (act) => false;

        public Predicate<Contract> ContractReadFilter
            => (contract) => true;

        public Predicate<Organisation> OrganisationReadFilter
            => (organisation) => accessOrganisationType.Contains(organisation.Type);

        public bool CanEditAct() => false;

        public bool CanEditAnimal() => false;

        public bool CanEditContract() => false;

        public bool CanEditOrganisation() => true;
    }
}
