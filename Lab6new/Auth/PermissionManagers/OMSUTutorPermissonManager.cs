using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Auth.PermissionManagers
{
    internal class OMSUTutorPermissonManager : IPermissionManager
    {
        //Куратор ОМСУ, Подписант ОМСУ

        public User User => throw new NotImplementedException();

        public Predicate<Animal> AnimalReadFilter => throw new NotImplementedException();

        public Predicate<Act> ActReadFilter => throw new NotImplementedException();

        public Predicate<Contract> ContractReadFilter => throw new NotImplementedException();

        public Predicate<Organisation> OrganisationReadFilter => throw new NotImplementedException();

        public bool CanEditAct()
        {
            throw new NotImplementedException();
        }

        public bool CanEditAnimal()
        {
            throw new NotImplementedException();
        }

        public bool CanEditContract()
        {
            throw new NotImplementedException();
        }

        public bool CanEditOrganisation()
        {
            throw new NotImplementedException();
        }
    }
}
