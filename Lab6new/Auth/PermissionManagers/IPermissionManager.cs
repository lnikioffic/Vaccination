using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Auth.PermissionManagers
{
    internal interface IPermissionManager
    {
        User User { get; }
        Predicate<ICard> ReadFilter {  get; }

        bool CanEdit();
        //кому-то говорят создай permMan он смотрит роль создает нужгный объект
    }
}
