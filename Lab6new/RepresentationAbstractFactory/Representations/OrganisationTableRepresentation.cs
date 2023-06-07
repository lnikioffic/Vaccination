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
    internal class OrganisationTableRepresentation : ITableRepresentation
    {
        [DisplayName("Название")]
        public string FullName { get; }

        [DisplayName("ИНН")]
        public string Inn { get; }

        [DisplayName("Тип")]
        public string Type { get; }

        [DisplayName("Лицо")]
        public string Entity { get; }

        [DisplayName("Нас.пункт")]
        public string Locality { get; }

        [Browsable(false)]
        public Organisation RepresentEntity { get; }

        public OrganisationTableRepresentation(Organisation organisation)
        {
            RepresentEntity = organisation;
            FullName = RepresentEntity.FullName;
            Inn = RepresentEntity.Inn;
            Type = RepresentEntity.Type;
            Entity = RepresentEntity.Entity ? "Юридическое" : "Физической";
            Locality = RepresentEntity.Locality.Locality1;
        }
    }
}
