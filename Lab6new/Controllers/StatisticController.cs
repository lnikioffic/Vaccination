using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationAbstractFactory.Fabrics;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class StatisticController
    {

        public StatisticController(IPermissionManager permissionManager,User user)
        {
            RepresentationFabric = new StatisticItemRepresentationFabric();
            PermissionManager = permissionManager;
            User = user;
        }

        public IPermissionManager PermissionManager { get; set; }
        private IRepresentationFabric<StatisticItem> RepresentationFabric { get; set; }

        public User User { get; set; }

        public List<StatisticItem> MakeStatistic(Predicate<Act> filter)
        {
            using (var db = new Lab3newContext())
            {
                var statistic = db.Acts
                    .Include(x=>x.Locality)
                    .Include(x=>x.Contract)
                        .ThenInclude(x=>x.Costs)
                            .ThenInclude(x=>x.Locality)
                    .AsEnumerable().Where(x=>filter(x))
                    .GroupBy(x => x.Locality)
                    .Select(x => new StatisticItem
                    {
                        Locality = x.Key,
                        VaccinesCount = x.Count(),
                        TotalCost = x.Select(y => y.Contract.Costs.Where(z => z.Locality == x.Key).Select(w => w.Cost1).First()).Sum()
                    }).AsQueryable().ToList();

                return statistic;
            }
        }

        public IEnumerable<ITableRepresentation> GetStatistic(List<Predicate<Act>> filters)
        {

            var resultFilter = filters;
            resultFilter.Add(PermissionManager.ActReadFilter);
            return MakeStatistic(resultFilter.GlueFilters())
                .Select(x => RepresentationFabric.CreateTableRepresentation(x))
                .ToList();
        }

    }
}
