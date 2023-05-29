using Lab6new.PermissionManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers.Interface
{
    interface IAuthController
    {
        IPermissionManager Authorization(string username, string password);
    }
}
