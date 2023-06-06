using Lab6new.Models;
using Lab6new.RepresentationAbstractFactory.Representations;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationAbstractFactory.Fabrics
{
    internal class StatisticItemRepresentationFabric : IRepresentationFabric<StatisticItem>
    {
        public IExportRepresentation CreateAnimalRepresentation(StatisticItem exportModel)
        {
            return new StatisticItemExportRepresentation(exportModel);
        }

        public ITableRepresentation CreateTableRepresentation(StatisticItem tableModel)
        {
            return new StatisticItemTableRepresentation(tableModel);
        }
    }
}
