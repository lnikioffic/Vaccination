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
    internal class OrganisationTableRepresentation : IOrganisationRepresentation
    {
        [DisplayName("Название")]
        public string FullName { get { return Organisation.FullName; } }

        [DisplayName("ИНН")]
        public string Inn { get { return Organisation.Inn; } }

        [DisplayName("Тип")]
        public string Type { get { { return Organisation.Type; } } }

        [DisplayName("Лицо")]
        public string Entity { get { return Organisation.Entity ? "Юридическое" : "Физической"; } }

        [DisplayName("Нас.пункт")]
        public string Locality { get { return Organisation.Locality.Locality1; } }

        [Browsable(false)]
        public Organisation Organisation { get; }

        public OrganisationTableRepresentation(Organisation organisation)
        {
            Organisation = organisation;
        }
    }
}
