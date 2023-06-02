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
    internal class AnimalTableRepresentation : IAnimalRepresentation
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
        public Animal Animal { get; }

        public AnimalTableRepresentation(Animal animal)
        {
            Animal = animal;
            RegistrationNumber = animal.RegistrationNumber;
            Category = animal.Category ? "собака" : "кошка";
            Sex = animal.Sex ? "самец" : "самка";
            ChipNumber = animal.ChipNumber;
            Name = animal.Name;
            Locality = animal.Locality.Locality1;
        }

        public void setValue(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
