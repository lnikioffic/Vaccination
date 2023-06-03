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
        [DisplayName("Регистрационный номер")]
        public string RegistrationNumber { get { return Animal.RegistrationNumber; } }

        [DisplayName(@"Животное")]
        public string Category { get { return Animal.Category ? "собака" : "кошка"; } }

        [DisplayName(@"Пол")]
        public string Sex { get { return Animal.Sex ? "самец" : "самка"; } }

        [DisplayName(@"Год рождения")]
        public int BirthYear { get { return Animal.BirthYear; } }

        [DisplayName(@"Номер чипа")]
        public string ChipNumber { get { return Animal.ChipNumber; } }

        [DisplayName(@"Кличка")]
        public string Name { get { return Animal.Name; } }

        [DisplayName(@"Особые приметы")]
        public string SpecialSigns { get { return Animal.SpecialSigns; } }

        [DisplayName(@"Фото")]
        public string Photo { get { return Animal.Photo; } }

        [DisplayName(@"Населеный пункт")]
        public string Locality { get { return Animal.Locality.Locality1; } }

        public Animal Animal { get; }

        public Act? lastAct { get { return Animal.Acts.OrderByDescending(x => x.EndDate).FirstOrDefault(); } }

        [DisplayName(@"Дата начала")]
        public DateOnly? actStartDate { get { return lastAct?.StartDate; } }

        [DisplayName(@"Дата окочания")]
        public DateOnly? actEndDate { get { return lastAct?.EndDate; } }

        [DisplayName(@"Тип вакцины")]
        public string? actType { get { return lastAct?.Type; } }

        public AnimalCardRepresentation(Animal animal)
        {
            Animal = animal;
        }

        public void setValue(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
