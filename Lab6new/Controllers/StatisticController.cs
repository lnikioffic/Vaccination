using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationAbstractFactory.Fabrics;
using Lab6new.RepresentationFactory.Interface;
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

        public List<StatisticItem> MakeStatistic(List<Predicate<Act>> filters)
        {
            using (var db = new Lab3newContext())
            {
                var statistic = db.Acts.Where(x => true)
                    .GroupBy(x => x.Locality)
                    .Select(x => new StatisticItem
                    {
                        Locality = x.Key,
                        VaccinesCount = x.Count(),
                        TotalCost = x.Select(y => y.Contract.Costs.Where(z => z.Locality == x.Key).Select(w => w.Cost1).First()).Sum()
                    }).ToList();

                return statistic;
            }
        }

        public IEnumerable<ITableRepresentation> GetStatistic(List<Predicate<Act>> filters)
        {

            var resultFilter = filters;
            resultFilter.Add(PermissionManager.ActReadFilter);
            return MakeStatistic(resultFilter)
                .Select(x => RepresentationFabric.CreateTableRepresentation(x))
                .ToList();
        }
    }
}
