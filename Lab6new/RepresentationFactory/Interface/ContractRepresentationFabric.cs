using Lab6new.Models;
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
            throw new NotImplementedException();
        }

        public ITableRepresentation CreateTableRepresentation(Contract tableModel)
        {
            return new ContractTableRepresentation(tableModel);
        }
    }
}
