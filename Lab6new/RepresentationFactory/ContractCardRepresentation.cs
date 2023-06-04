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
    internal class ContractCardRepresentation : IContractRepresentation
    {
        [DisplayName(@"Номер")]
        public string Number { get; }

        [DisplayName(@"Заказчик")]
        public string OrderOrganisation { get; }

        [DisplayName(@"Исполнитель")]
        public string PerformOrganisation { get; }

        [DisplayName(@"Дата начала")]
        public DateOnly? ContractStartDate { get; }

        [DisplayName(@"Дата окочания")]
        public DateOnly? ContractEndDate { get; }

        public Contract Contract { get; }

        public Cost? Cost { get; }

        [DisplayName("Средняя стоимость")]
        public double Costs { get; }

        public ContractCardRepresentation(Contract contract)
        {
            Contract = contract;
            Number = contract.Number;
            OrderOrganisation = contract.OrderOrganisation.FullName;
            PerformOrganisation = contract.PerformOrganisation.FullName;
            ContractStartDate = contract.StartDate;
            ContractEndDate = contract.EndDate;
            Cost = contract.Costs.FirstOrDefault();
            Costs = Cost.Cost1;
        }
    }
}
