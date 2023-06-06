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
    internal class OrganisationExportRepresentation : IExportRepresentation
    {
        public string FullName { get { return RepresentEntity.FullName; } }

        public string Inn { get { return RepresentEntity.Inn; } }

        public string Kpp { get { return RepresentEntity.Kpp; } }

        public string Address { get { return RepresentEntity.Address; } }

        public string Type { get { { return RepresentEntity.Type; } } }

        public string Entity { get { return RepresentEntity.Entity ? "Юридическое" : "Физической"; } }

        public string Locality { get { return RepresentEntity.Locality.Locality1; } }

        public Organisation RepresentEntity { get; }

        public OrganisationExportRepresentation(Organisation organisation)
        {
            RepresentEntity = organisation;
        }

        public object[] GetExportData()
        {
            return new object[]
            {
                FullName,Inn,Kpp, Address, Type, Entity, Locality
            };
        }

        public object[] GetExportColumnsNames()
        {
            return new object[]
            {
                "Название","ИНН","КПП","Адрес","Тип","Лицо","Нас. пункт"
            };
        }
    }
}
