using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    internal class OMSUTutorPermissonManager : IPermissionManager
    {
        //Куратор ОМСУ, Подписант ОМСУ

        public OMSUTutorPermissonManager(User user)
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
            .Select((cost) => cost.Locality.DistrictId)
            .Contains(User.Organisation.Locality.DistrictId);

        public Predicate<Organisation> OrganisationReadFilter
            => (organisation) => organisation.Locality.DistrictId == User.Organisation.Locality.DistrictId;

        public bool CanEditAct() => false;        

        public bool CanEditAnimal() => false;

        public bool CanEditContract() => false;

        public bool CanEditOrganisation() => false;
    }
}
