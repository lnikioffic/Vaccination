using Lab6new.Controllers.Interface;
using Lab6new.PermissionManagers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class AuthController : IAuthController
    {
        public IPermissionManager Authorization(string login, string password)
        {

            using (var db = new Lab3newContext())
            {
                var user = db.Users
                    .Include((user) => user.Organisation)
                        .ThenInclude((organisation) => organisation.Locality)
                            .ThenInclude((locality) => locality.District)
                     .Include((user) => user.Organisation)
                        .ThenInclude((organisation) => organisation.ContractPerformOrganisations)
                            .ThenInclude(x=>x.Costs)
                                .ThenInclude(x=>x.Locality)
                    .Where((user) => user.Login == login && user.Password == GetHash(password))
                    .FirstOrDefault();

                if (user != null)
                    return PermissionManagerFactory.CreatePermissonManager(user);

                throw new ArgumentException("Неверный логин или пароль");
            }
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

    }
}
