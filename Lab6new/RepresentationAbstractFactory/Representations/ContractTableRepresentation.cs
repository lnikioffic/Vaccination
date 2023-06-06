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
        public string Number { get; }

        [DisplayName(@"Заказчик")]
        public string OrderOrganisation { get; }

        [DisplayName(@"Исполнитель")]
        public string PerformOrganisation { get; }

        [DisplayName(@"Дата начала")]
        public DateOnly ContractStartDate { get; }

        [DisplayName(@"Дата окочания")]
        public DateOnly ContractEndDate { get ; }

        [Browsable (false)]
        public List<Cost> Costs { get; }

        [DisplayName("Средняя стоимость")]
        public double AverageCost { get; }

        [Browsable(false)]
        public Contract RepresentEntity { get; }

        public ContractTableRepresentation(Contract contract)
        {
            RepresentEntity = contract;
            Number = RepresentEntity.Number;
            OrderOrganisation = RepresentEntity.OrderOrganisation.FullName;
            PerformOrganisation= RepresentEntity.PerformOrganisation.FullName;
            ContractStartDate = RepresentEntity.StartDate;
            ContractEndDate = RepresentEntity.EndDate;
            Costs= RepresentEntity.Costs.ToList();
            AverageCost= Math.Round(Costs.Select(x => x.Cost1).Average(), 2);
        }
    }
}
