using Lab6new.Models;
using Lab6new.RepresentationFactory.Representations;
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
            return new OrganisationExportRepresentation(exportModel);
        }

        public ITableRepresentation CreateTableRepresentation(Organisation tableModel)
        {
            return new OrganisationTableRepresentation(tableModel);
        }
    }
}
