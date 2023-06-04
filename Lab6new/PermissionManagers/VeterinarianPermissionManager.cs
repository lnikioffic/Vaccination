using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    internal class VeterinarianPermissionManager : IPermissionManager
    {
        //Ветврач, Ветврач приюта, Оператор приюта

        public VeterinarianPermissionManager(User user)
        {
            User = user;
        }
        public User User { get; }

        public Predicate<Animal> AnimalReadFilter
             => (animal) => true;

        public Predicate<Act> ActReadFilter
            => (act) => true;

        public Predicate<Contract> ContractReadFilter
            => (contract) => false;

        public Predicate<Organisation> OrganisationReadFilter
            => (contract) => false;

        public Predicate<Locality> LocalityReadFilter
            => (locality)=>true;

        public bool CanEditAct()=> true;

        public bool CanEditAnimal()=> true;

        public bool CanEditContract()=> false;

        public bool CanEditOrganisation() => false;

    }
}
