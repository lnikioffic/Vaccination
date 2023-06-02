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
    internal class OrganisationCardRepresentation : IOrganisationRepresentation
    {
        [DisplayName("Название")]
        public string FullName { get; }

        [DisplayName("ИНН")]
        public string Inn { get; }

        [DisplayName("КПП")]
        public string Kpp { get; }

        [DisplayName("Адрес")]
        public string Address { get; }

        [DisplayName("Тип")]
        public string Type { get; }

        [DisplayName("Лицо")]
        public string Entity { get; }

        [DisplayName("Город")]
        public string Locality { get; }

        [DisplayName("Район")]
        public string District { get; }

        public Organisation Organisation { get; }

        public OrganisationCardRepresentation(Organisation organisation)
        {
            Organisation = organisation;
            FullName = organisation.FullName;
            Inn = organisation.Inn;
            Kpp = organisation.Kpp;
            Address = organisation.Address;
            Type = organisation.Type;
            Entity = organisation.Entity ? "Физической" : "Юридическое";
            Locality = organisation.Locality.Locality1;
            District = organisation.Locality.District.District1;
        }
    }
}
