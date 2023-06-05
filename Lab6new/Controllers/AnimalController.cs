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

        private CRUDCardController<Animal> CRUDCardController
        {
            get
            {
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

        private void CheckPermissons()
        {
            if (!PermissionManager.CanEditAnimal())
                throw new Exception("У вас недостаточно прав");
        }

        public User User { get; }

        public IPermissionManager PermissionManager { get; }

        private IRepresentationFabric RepresentationFabric { get; }

        public bool Validate(Animal animal)
        {
            var notEmptyField = animal.Name != "" && animal.SpecialSigns != ""
                && animal.RegistrationNumber != "" && animal.ChipNumber != "";
            var uniqueField = GetData((x) => (x.RegistrationNumber == animal.RegistrationNumber
            || x.ChipNumber == animal.ChipNumber) && x.Id != animal.Id, (x) => true)
                .FirstOrDefault() == null;
            var inputField = animal.BirthYear != 0;
            return notEmptyField && uniqueField && inputField;
        }

        public void Update(Animal animal)
        {
            CheckPermissons();
            if (Validate(animal))
            {
                using(var db = new Lab3newContext())
                {
                    var anim = db.Animals.Single(x=>x.Id == animal.Id);
                    anim.Name = animal.Name;
                    anim.ChipNumber = animal.ChipNumber;
                    anim.BirthYear = animal.BirthYear;
                    anim.RegistrationNumber = animal.RegistrationNumber;
                    anim.Sex = animal.Sex;
                    anim.Category = animal.Category;
                    anim.SpecialSigns = animal.SpecialSigns;
                    anim.Locality = db.Localities.Single(x=>x.Id == animal.Locality.Id);
                    db.SaveChanges();
                }
            }
            else
                throw new Exception("Не верно введеные данные");
        }

        public void Delete(Animal animal)
        {
            if (animal.Acts.Count == 0)
                CRUDCardController.Delete(animal);
            else
                throw new Exception("Нельзя удалять животное, у которго есть акты вакцинации");
        }

        public IEnumerable<IAnimalRepresentation> GetAnimals(List<Predicate<Animal>> filters, Func<Animal, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.AnimalReadFilter);
            return GetData(resultFilter.GlueFilters(), sort, sortType)
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
