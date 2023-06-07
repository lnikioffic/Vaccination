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
    internal class AnimalTableRepresentation : ITableRepresentation
    {
        [DisplayName(@"Регистрационный номер")]
        public string RegistrationNumber { get; }

        [DisplayName(@"Животное")]
        public string Category { get; }

        [DisplayName(@"Пол")]
        public string Sex { get; }

        [DisplayName(@"Номер чипа")]
        public string ChipNumber { get; }

        [DisplayName(@"Кличка")]
        public string Name { get; }

        [DisplayName(@"Населеный пункт")]
        public string Locality { get; }

        [Browsable(false)]
        public Animal RepresentEntity { get; }

        public AnimalTableRepresentation(Animal animal)
        {
            RepresentEntity = animal;
            RegistrationNumber= RepresentEntity.RegistrationNumber;
            Category = RepresentEntity.Category ? "собака" : "кошка";
            Sex = RepresentEntity.Sex ? "самец" : "самка";
            ChipNumber = RepresentEntity.ChipNumber;
            Name = RepresentEntity.Name;
            Locality = RepresentEntity.Locality.Locality1;
        }
    }
}
