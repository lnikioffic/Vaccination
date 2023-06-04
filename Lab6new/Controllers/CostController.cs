using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class CostController
    {
        public CostController(IPermissionManager permissionManager, User user)
        {
            User = user;
            PermissionManager = permissionManager;
        }

        private CRUDCardController<Cost> CRUDCardController
        {
            get
            {
                if (PermissionManager.CanEditAct())
                    return new CRUDCardController<Cost>();
                throw new Exception("У вас недостаточно прав");
            }
        }
        public void Add(Cost cost)
        {
            CRUDCardController.Add(cost);
        }

        public User User { get; }

        public IPermissionManager PermissionManager { get; }
    }
}
