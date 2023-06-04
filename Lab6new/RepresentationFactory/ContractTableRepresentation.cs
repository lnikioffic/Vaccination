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
    internal class ContractTableRepresentation : IContractRepresentation
    {
        [DisplayName(@"Номер")]
        public string Number { get { return Contract.Number; } }

        [DisplayName(@"Заказчик")]
        public string OrderOrganisation { get { return Contract.OrderOrganisation.FullName; } }

        [DisplayName(@"Исполнитель")]
        public string PerformOrganisation { get { return Contract.PerformOrganisation.FullName; } }

        [DisplayName(@"Дата начала")]
        public DateOnly ContractStartDate { get {return Contract.StartDate; } }

        [DisplayName(@"Дата окочания")]
        public DateOnly ContractEndDate { get { return Contract.EndDate; } }

        [Browsable(false)]
        public Contract Contract { get; }

        [Browsable (false)]
        public List<Cost> Costs { get { return Contract.Costs.ToList(); } }

        [DisplayName("Средняя стоимость")]
        public double AverageCost { get { return Math.Round(Costs.Select(x => x.Cost1).Average(), 2); } }


        public ContractTableRepresentation(Contract contract)
        {
            Contract = contract;
        }
    }
}
