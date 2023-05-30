using Lab6new.Models;
using Lab6new.PermissionManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class ContractController:CRUDCardController<Contract>
    {
        public ContractController(IPermissionManager permissionManager, User user)
        {
            User = user;
            PermissionManager = permissionManager;
        }

        private User User { get; }

        public IPermissionManager PermissionManager { get; }
    }
}
