using Lab6new.Models;
using Lab6new.RepresentationFactory.Representations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal class ContractRepresentationFabric : IRepresentationFabric<Contract>
    {
        public IExportRepresentation CreateAnimalRepresentation(Contract exportModel)
        {
            return new ContractExportRepresentation(exportModel);
        }

        public ITableRepresentation CreateTableRepresentation(Contract tableModel)
        {
            return new ContractTableRepresentation(tableModel);
        }
    }
}
