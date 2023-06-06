using Lab6new.Models;
using Lab6new.RepresentationFactory.Representations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal class AnimalRepresentationFabric : IRepresentationFabric<Animal>
    {
        public IExportRepresentation CreateAnimalRepresentation(Animal exportModel)
        {
            return new AnimalExportRepresentation(exportModel);
        }

        public ITableRepresentation CreateTableRepresentation(Animal tableModel)
        {
            return new AnimalTableRepresentation(tableModel);
        }
    }
}
