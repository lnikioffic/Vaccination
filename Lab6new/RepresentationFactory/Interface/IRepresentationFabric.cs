using Lab6new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal interface IRepresentationFabric<T>
    {
        IExportRepresentation CreateAnimalRepresentation(T exportModel);

        ITableRepresentation CreateTableRepresentation(T tableModel);
    }
}
