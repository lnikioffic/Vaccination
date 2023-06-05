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
                if (PermissionManager.CanEditContract())
                    return new CRUDCardController<Cost>();
                throw new Exception("У вас недостаточно прав");
            }
        }
        private bool Validate(Cost cost)
        {
            return cost.Cost1 != 0;
        }
        public void Add(Cost cost)
        {
            if (Validate(cost))
                CRUDCardController.Add(cost);
            else
                throw new Exception("Цена контракта не может быть равна 0");
        }

        public void Delete(Cost cost)
        {
            if (Validate(cost))
                CRUDCardController.Delete(cost);
            else
                throw new Exception("Цена контракта не может быть равна 0");
        }

        public User User { get; }

        public IPermissionManager PermissionManager { get; }
    }
}
