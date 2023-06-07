using Lab6new.Models;
using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationFactory.Interface
{
    internal interface IRepresentationFabric<T>
        where T : class,IModel
    {
        IExportRepresentation CreateAnimalRepresentation(T exportModel);

        ITableRepresentation CreateTableRepresentation(T tableModel);
    }
}
