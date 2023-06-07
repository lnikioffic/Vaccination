using Lab6new.Models;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.RepresentationAbstractFactory.Representations
{
    internal class StatisticItemTableRepresentation:ITableRepresentation
    {
        [DisplayName(@"Нас. пункт")]
        public string Locality { get; }

        [DisplayName(@"Количество поставленых вакцин")]
        public string VaccinesCount { get; }

        [DisplayName(@"Общая стоимость")]
        public string TotalCost { get; }

        [Browsable(false)]
        public StatisticItem RepresentEntity { get; set; }
        public StatisticItemTableRepresentation(StatisticItem statisticItem) { 
            RepresentEntity = statisticItem;
            Locality = RepresentEntity.Locality.Locality1;
            VaccinesCount = RepresentEntity.VaccinesCount.ToString();
            TotalCost = Math.Round(RepresentEntity.TotalCost, 2).ToString();
        }
    }
}
