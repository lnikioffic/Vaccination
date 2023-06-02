using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory
{
    internal class AnimalCardRepresentation : IAnimalRepresentation
    {
        [DisplayName(@"Регистрационный номер")]
        public string RegistrationNumber { get; }

        [DisplayName(@"Животное")]
        public string Category { get; }

        [DisplayName(@"Пол")]
        public string Sex { get; }

        [DisplayName(@"Год рождения")]
        public int BirthYear { get; }

        [DisplayName(@"Номер чипа")]
        public string ChipNumber { get; }

        [DisplayName(@"Кличка")]
        public string Name { get; }

        [DisplayName(@"Особые приметы")]
        public string SpecialSigns { get; }

        [DisplayName(@"Фото")]
        public string Photo { get; }

        [DisplayName(@"Населеный пункт")]
        public string Locality { get; }

        public Animal Animal { get; }

        public Act? CurrentAct { get; }


        [DisplayName(@"Дата начала")]
        public DateOnly? actStartDate { get { return CurrentAct?.StartDate; } }

        [DisplayName(@"Дата окочания")]
        public DateOnly? actEndDate { get { return CurrentAct?.EndDate; } }

        [DisplayName(@"Тип вакцины")]
        public string? actType { get { return CurrentAct?.Type; } }

        public AnimalCardRepresentation(Animal animal)
        {
            Animal = animal;
            RegistrationNumber = animal.RegistrationNumber;
            Category = animal.Category ? "собака" : "кошка";
            Sex = animal.Sex ? "самец" : "самка";
            BirthYear = animal.BirthYear;
            ChipNumber = animal.ChipNumber;
            Name = animal.Name;
            SpecialSigns = animal.SpecialSigns;
            Photo = animal.Photo;
            Locality = animal.Locality.Locality1;
            CurrentAct = animal.Acts.Where(x => x.EndDate >= DateOnly.FromDateTime(DateTime.Now)).FirstOrDefault();
        }

        public void setValue(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
