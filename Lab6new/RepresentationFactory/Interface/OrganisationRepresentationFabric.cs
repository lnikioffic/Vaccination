using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal class OrganisationRepresentationFabric : IRepresentationFabric<Organisation>
    {
        public IExportRepresentation CreateAnimalRepresentation(Organisation exportModel)
        {
            throw new NotImplementedException();
        }

        public ITableRepresentation CreateTableRepresentation(Organisation tableModel)
        {
            return new OrganisationTableRepresentation(tableModel);
        }
    }
}
