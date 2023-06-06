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
        public string RegistrationNumber { get {return RepresentEntity.RegistrationNumber; } }

        [DisplayName(@"Животное")]
        public string Category { get {return RepresentEntity.Category ? "собака" : "кошка"; } }

        [DisplayName(@"Пол")]
        public string Sex { get {return RepresentEntity.Sex ? "самец" : "самка"; } }

        [DisplayName(@"Номер чипа")]
        public string ChipNumber { get {return RepresentEntity.ChipNumber; } }

        [DisplayName(@"Кличка")]
        public string Name { get { return RepresentEntity.Name; } }

        [DisplayName(@"Населеный пункт")]
        public string Locality { get {return RepresentEntity.Locality.Locality1; } }

        [Browsable(false)]
        public Animal RepresentEntity { get; }

        public AnimalTableRepresentation(Animal animal)
        {
            RepresentEntity = animal;
        }
    }
}
