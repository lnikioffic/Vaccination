using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
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
        }

        public CRUDCardController<Act> CRUDCardController
        {
            get
            {
                if (PermissionManager.CanEditAnimal())
                    return new CRUDCardController<Act>();
                throw new Exception("У вас недостаточно прав");
            }
        }

        public User User { get; }

        public IPermissionManager PermissionManager { get; }


        public bool Validate(Act act)
        {
            return GetData((x) => x.SerialNumber == act.SerialNumber && x.Id != act.Id, (x) => true)
                .FirstOrDefault() == null && act.Type != "" && act.SerialNumber != "";
        }

        public void Add(Act act)
        {
            if (Validate(act))
                CRUDCardController.Add(act);
            else
                throw new Exception("Не верно введеные данные");
        }

        public void Update(Act act)
        {
            if (Validate(act))
                CRUDCardController.Update(act);
            else
                throw new Exception("Не верно введеные данные");
        }

        public List<Act> GetActs(List<Predicate<Act>> filters, Func<Act, object> sort)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.ActReadFilter);
            return GetData(resultFilter.GlueFilters(), sort).ToList();
        }

        public Act GetAct(Act act)
        {
            var filters = new List<Predicate<Act>> { (x) => x.Id == act.Id, PermissionManager.ActReadFilter };
            var result = GetData(filters.GlueFilters(), x => true).FirstOrDefault();
            if (result != null)
                return result;
            throw new Exception("Акт не найдн");
        }

        private  List<Act> GetData(Predicate<Act> filter, Func<Act, object> sort)
        {
            using (var db = new Lab3newContext())
            {
                return db.Acts
                    .Include(x => x.User)
                        .ThenInclude(x => x.Organisation)
                            .ThenInclude(x => x.Locality)
                    .Include(x => x.User)
                        .ThenInclude(x => x.Organisation)
                            .ThenInclude(x => x.ContractPerformOrganisations)
                                .ThenInclude(x=>x.Costs)
                                    .ThenInclude(x=>x.Locality)
                    .AsEnumerable()
                    .Where(x => filter(x))
                    .OrderBy(sort)
                    .AsQueryable()
                    .ToList();
            }

        }
    }
}
