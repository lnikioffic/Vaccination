using Lab6new.Models;
using Lab6new.PermissionManagers;
using Lab6new.RepresentationFactory;
using Lab6new.RepresentationFactory.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Controllers
{
    internal class AnimalController
    {

        public CRUDCardController<Animal> CRUDCardController { 
            get {
                if (PermissionManager.CanEditAnimal())
                    return new CRUDCardController<Animal>();
                throw new Exception("У вас недостаточно прав");
            } 
        }

        public AnimalController(IPermissionManager permissionManager, User user, IRepresentationFabric representationFabric)
        {
            User = user;
            PermissionManager = permissionManager;
            RepresentationFabric = representationFabric;
        }


        public User User { get; }

        public IPermissionManager PermissionManager { get; }

        private IRepresentationFabric RepresentationFabric { get; }

        public bool Validate(Dictionary<string, string> fields)
        {
            var notEmptyField = fields["name"] != "" && fields["specialSigns"] != "";
            var uniqueField = GetData((x) => x.RegistrationNumber == fields["regNumb"]
            || x.ChipNumber == fields["chipNumb"], (x) => true)
                .FirstOrDefault() == null;
            var selectedField = (fields["sex"] == "самец" || fields["sex"] == "самка") && (fields["category"] == "собака" || fields["category"] == "кошка");
            var birth = 0;
            var inputField = int.TryParse(fields["birthYear"], out birth);            
            return notEmptyField  && selectedField && inputField;
        }

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
