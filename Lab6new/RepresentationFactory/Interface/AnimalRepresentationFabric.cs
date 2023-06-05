using Lab6new.Models;
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
            throw new NotImplementedException();
        }

        public ITableRepresentation CreateTableRepresentation(Animal tableModel)
        {
            return new AnimalTableRepresentation(tableModel);
        }
    }
}
