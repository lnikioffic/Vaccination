﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Auth.PermissionManagers
{
    internal class PermissionManagerFactory
    {
        internal IPermissionManager CreatePermissonManager(User user)
        {
            return new OMSUOperatorPermissionManager(user);
        }
    }
}
