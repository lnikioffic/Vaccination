﻿using Lab6new.Models;
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
        public string FullName { get { return RepresentEntity.FullName; } }

        [DisplayName("ИНН")]
        public string Inn { get { return RepresentEntity.Inn; } }

        [DisplayName("Тип")]
        public string Type { get { { return RepresentEntity.Type; } } }

        [DisplayName("Лицо")]
        public string Entity { get { return RepresentEntity.Entity ? "Юридическое" : "Физической"; } }

        [DisplayName("Нас.пункт")]
        public string Locality { get { return RepresentEntity.Locality.Locality1; } }

        [Browsable(false)]
        public Organisation RepresentEntity { get; }

        public OrganisationTableRepresentation(Organisation organisation)
        {
            RepresentEntity = organisation;
        }
    }
}