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
    internal class ContractExportRepresentation : IExportRepresentation
    {
        public string Number { get { return RepresentEntity.Number; } }

        public string OrderOrganisation { get { return RepresentEntity.OrderOrganisation.FullName; } }

        public string PerformOrganisation { get { return RepresentEntity.PerformOrganisation.FullName; } }

        public DateOnly ContractStartDate { get { return RepresentEntity.StartDate; } }

        
        public DateOnly ContractEndDate { get { return RepresentEntity.EndDate; } }

        public string Costs
        {
            get
            {
                var result = new List<string>();
                foreach (var cost in RepresentEntity.Costs)
                    result.Add(cost.ToString());
                return String.Join("\n", result);
            }
        }

        public Contract RepresentEntity { get; }

        public ContractExportRepresentation(Contract contract)
        {
            RepresentEntity = contract;
        }

        public object[] GetExportData()
        {
            return new object[]
            {
                Number, OrderOrganisation, PerformOrganisation, ContractStartDate, ContractEndDate, Costs
            };
        }

        public object[] GetExportColumnsNames()
        {
            return new object[]
            {
                "Номер","Заказчик","Исполнитель","Дата начала","Дата окочания","Нас.пункты, в которых действуют контракты"
            };
        }
    }
}
