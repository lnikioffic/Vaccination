using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory
{
    internal class AnimalTableRepresentation : IAnimalRepresentation
    {
        string registrationNumber;
        string category;
        string sex;
        string chipNumber;
        string name;
        string specialSigns;
        string locality;

        public void setValue(Animal animal)
        {
            registrationNumber = animal.RegistrationNumber;
            category = animal.Category.ToString();
            sex = animal.Sex ? "собака" : "кошка";
            chipNumber = animal.ChipNumber;
            name = animal.Name;
            specialSigns = animal.SpecialSigns.Substring(10) + "...";
            locality = animal.Locality.Locality1;
        }
    }
}
