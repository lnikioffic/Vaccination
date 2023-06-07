using Lab6new.Controllers.Interface;
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
    internal class AnimalController:IExportDataController<Animal>
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

        public AnimalController(IPermissionManager permissionManager, User user, IRepresentationFabric<Animal> representationFabric)
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

        private IRepresentationFabric<Animal> RepresentationFabric { get; }

        public void Validate(Animal animal)
        {
            var errors = new List<string>();
            if (animal.Name == "" || animal.SpecialSigns == "" || animal.RegistrationNumber == "" || animal.ChipNumber == "")
                errors.Add("Поля: Кличка,Регистрационный номер, Номер чипа, Особые примет. Не могут быть пустыми");

            if (GetData((x) => (x.RegistrationNumber == animal.RegistrationNumber ||
            x.ChipNumber == animal.ChipNumber) && x.Id != animal.Id, (x) => true)
                .FirstOrDefault() != null)
                errors.Add("Регистрационный номер и Номер чипа, должны быть уникальны");

            if (animal.BirthYear == 0)
                errors.Add("Год рождения не валиден");

            if (errors.Count > 0)
                throw new ArgumentException(String.Join("\n", errors));
        }

        public void Update(Animal animal)
        {
            CheckPermissons();
            Validate(animal);
            using (var db = new Lab3newContext())
            {
                var anim = db.Animals.Single(x => x.Id == animal.Id);
                anim.Name = animal.Name;
                anim.ChipNumber = animal.ChipNumber;
                anim.BirthYear = animal.BirthYear;
                anim.RegistrationNumber = animal.RegistrationNumber;
                anim.Sex = animal.Sex;
                anim.Category = animal.Category;
                anim.SpecialSigns = animal.SpecialSigns;
                anim.Locality = db.Localities.Single(x => x.Id == animal.Locality.Id);
                db.SaveChanges();
            }
        }

        public void Delete(Animal animal)
        {
            if (animal.Acts.Count == 0)
                CRUDCardController.Delete(animal);
            else
                throw new Exception("Нельзя удалять животное, у которго есть акты вакцинации");
        }

        public IEnumerable<ITableRepresentation> GetAnimals(List<Predicate<Animal>> filters, Func<Animal, object> sort, bool sortType = false)
        {
            var resultFilter = filters;
            resultFilter.Add(PermissionManager.AnimalReadFilter);
            return GetData(resultFilter.GlueFilters(), sort, sortType)
                .Select(
                (x) => RepresentationFabric
                .CreateTableRepresentation(x)
                );
        }

        public Animal GetAnimal(Animal animal)
        {
            var filters = new List<Predicate<Animal>> { PermissionManager.AnimalReadFilter, x => x.Id == animal.Id };
            var result = GetData(filters.GlueFilters(), x => true).FirstOrDefault();
            if (result != null)
                return result;
            throw new Exception("Животное не найдено");
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
