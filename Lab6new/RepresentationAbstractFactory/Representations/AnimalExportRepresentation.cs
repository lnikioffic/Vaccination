using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Representations
{
    internal class AnimalExportRepresentation : IExportRepresentation
    {
        public string RegistrationNumber { get { return Animal.RegistrationNumber; } }

        public string Category { get { return Animal.Category ? "собака" : "кошка"; } }

        public string Sex { get { return Animal.Sex ? "самец" : "самка"; } }

        public int BirthYear { get { return Animal.BirthYear; } }

        public string ChipNumber { get { return Animal.ChipNumber; } }

        public string Name { get { return Animal.Name; } }

        public string Locality { get { return Animal.Locality.Locality1; } }

        public string SpecialSigns { get { return Animal.SpecialSigns; } }

        public Animal Animal { get; }

        public AnimalExportRepresentation(Animal animal)
        {
            Animal = animal;
        }

        public object[] GetExportData()
        {
            return new object[]
            {
                RegistrationNumber, Category, Sex, BirthYear, ChipNumber, Name, Locality, SpecialSigns
            };
        }

        public object[] GetExportColumnsNames()
        {
            return new object[]
            {
                "Регистрационный номер","Животное","Пол","Год рождения","Номер чипа","Кличка","Населеный пункт","Особые приметы"
            };
        }
    }
}
