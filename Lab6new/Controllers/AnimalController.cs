using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class AnimalController
    {

        private CRUDCardController<Animal> CRUDCardController { get; }

        public AnimalController(IPermissionManager permissionManager, User user, IRepresentationFabric representationFabric)
        {
            User = user;
            PermissionManager = permissionManager;
            CRUDCardController = new CRUDCardController<Animal>();
            RepresentationFabric = representationFabric;
        }


        private User User { get; }

        public IPermissionManager PermissionManager { get; }

        private IRepresentationFabric RepresentationFabric { get; }

        public IEnumerable<IAnimalRepresentation> GetAnimals(List<Predicate<Animal>> filters, Func<Animal, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.AnimalReadFilter);
            return GetData(FilterService.GlueFilters(resultFilter), sort, sortType)
                .Select(
                (x) => RepresentationFabric
                .createAnimalRepresentation(x)
                );
        }

        public List<Animal> GetData(Predicate<Animal> filter, Func<Animal, object> sort, bool descending = false)
        {
            using (var db = new Lab3newContext())
            {
                var animals = db.Animals
                    .Include(x => x.Locality)
                    .Include(x => x.Acts)
                    .AsEnumerable()
                    .Where(x => filter(x))
                    .OrderBy(sort)
                    .AsQueryable();
                    if (descending)
                    return animals.Reverse().ToList();
                return animals.ToList();
            }
        }


    }
}
