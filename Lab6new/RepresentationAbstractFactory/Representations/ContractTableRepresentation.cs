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
    internal class ContractTableRepresentation : ITableRepresentation
    {
        [DisplayName(@"Номер")]
        public string Number { get { return RepresentEntity.Number; } }

        [DisplayName(@"Заказчик")]
        public string OrderOrganisation { get { return RepresentEntity.OrderOrganisation.FullName; } }

        [DisplayName(@"Исполнитель")]
        public string PerformOrganisation { get { return RepresentEntity.PerformOrganisation.FullName; } }

        [DisplayName(@"Дата начала")]
        public DateOnly ContractStartDate { get {return RepresentEntity.StartDate; } }

        [DisplayName(@"Дата окочания")]
        public DateOnly ContractEndDate { get { return RepresentEntity.EndDate; } }

        [Browsable (false)]
        public List<Cost> Costs { get { return RepresentEntity.Costs.ToList(); } }

        [DisplayName("Средняя стоимость")]
        public double AverageCost { get { return Math.Round(Costs.Select(x => x.Cost1).Average(), 2); } }

        [Browsable(false)]
        public Contract RepresentEntity { get; }

        public ContractTableRepresentation(Contract contract)
        {
            RepresentEntity = contract;
        }
    }
}
