using Lab6new.Models;
using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    public interface IPermissionManager
    {
        User User { get; }

        Predicate<Animal> AnimalReadFilter { get; }

        Predicate<Act> ActReadFilter { get; }

        Predicate<Contract> ContractReadFilter { get; }

        Predicate<Organisation> OrganisationReadFilter { get; }

        bool CanEditAnimal();

        bool CanEditAct();

        bool CanEditContract();

        bool CanEditOrganisation();
    }
}
