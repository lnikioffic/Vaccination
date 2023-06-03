using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class ActController
    {


        public ActController(IPermissionManager permissionManager, User user)
        {
            User = user;
            PermissionManager = permissionManager;
            CRUDCardController = new CRUDCardController<Act>();
        }

        public CRUDCardController<Act> CRUDCardController { get; }

        public User User { get; }

        public IPermissionManager PermissionManager { get; }


        public bool Validate(string duration,string type,string serialNumb)
        {
            var i = 0;
            return int.TryParse(duration,out i) && type != "" && serialNumb !="";
        }

        public List<Locality> GetData(Predicate<Locality> filter, Func<Locality, object> sort)
        {
            using (var db = new Lab3newContext())
            {
                return db.Localities
                    .Include(x => x.District)
                    .AsEnumerable()
                    .Where(x => filter(x))
                    .OrderBy(sort)
                    .AsQueryable()
                    .ToList();
            }
        }
    }
}
