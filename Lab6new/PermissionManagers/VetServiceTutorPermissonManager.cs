using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    internal class VetServiceTutorPermissonManager : IPermissionManager
    {
        //Подписант Ветслужбы, Куратор Ветслужбы  
        public VetServiceTutorPermissonManager(User user)
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
            => (organisation) => true;

        public bool CanEditAct() => false;

        public bool CanEditAnimal() => false;

        public bool CanEditContract() => false;

        public bool CanEditOrganisation() => false;
    }
}
