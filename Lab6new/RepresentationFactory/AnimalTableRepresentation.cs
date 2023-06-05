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
        public string RegistrationNumber { get {return Animal.RegistrationNumber; } }

        [DisplayName(@"Животное")]
        public string Category { get {return Animal.Category ? "собака" : "кошка"; } }

        [DisplayName(@"Пол")]
        public string Sex { get {return Animal.Sex ? "самец" : "самка"; } }

        [DisplayName(@"Номер чипа")]
        public string ChipNumber { get {return Animal.ChipNumber; } }

        [DisplayName(@"Кличка")]
        public string Name { get { return Animal.Name; } }

        [DisplayName(@"Населеный пункт")]
        public string Locality { get {return Animal.Locality.Locality1; } }

        [Browsable(false)]
        public Animal Animal { get; }

        public AnimalTableRepresentation(Animal animal)
        {
            Animal = animal;
        }

        public void setValue(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
