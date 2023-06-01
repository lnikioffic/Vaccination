using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory
{
    internal class AnimalCardRepresentation : IAnimalRepresentation
    {
        string? registrationNumber;
        string? category;
        string? sex;
        string? chipNumber;
        string? name;
        string? specialSigns;
        string? locality;
        Act? act;
        public void setValue(Animal animal)
        {
            registrationNumber = animal.RegistrationNumber;
            category = animal.Category.ToString();
            sex = animal.Sex ? "собака" : "кошка";
            chipNumber = animal.ChipNumber;
            name = animal.Name;
            specialSigns = animal.SpecialSigns;
            locality = animal.Locality.Locality1;
            act = animal.Acts.OrderByDescending(i => i.EndDate).FirstOrDefault();
        }
    }
}
