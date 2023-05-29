using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.PermissionManagers
{
    internal class PermissionManagerFactory
    {
        private static Dictionary<string, Func<User, IPermissionManager>> permissions
            = new Dictionary<string, Func<User, IPermissionManager>>()
        {
                {"Оператор ОМСУ",(user)=>new OMSUOperatorPermissionManager(user) },
                {"Куратор ОМСУ",(user)=>new OMSUTutorPermissonManager(user) },
                {"Подписант ОМСУ",(user)=>new OMSUTutorPermissonManager(user) },
                {"Ветврач",(user)=>new VeterinarianPermissionManager(user) },
                {"Ветврач приюта",(user)=>new VeterinarianPermissionManager(user) },
                {"Оператор приюта",(user)=>new VeterinarianPermissionManager(user) },
                {"Оператор Ветслужбы",(user)=>new VetServiceOperatorPermissonManager(user) },
                {"Подписант Ветслужбы",(user)=>new VetServiceTutorPermissonManager(user) },
                {"Куратор Ветслужбы ",(user)=>new VetServiceTutorPermissonManager(user) },
        };

        internal static IPermissionManager CreatePermissonManager(User user)
        {
            return permissions[user.Role](user);
        }
    }
}
