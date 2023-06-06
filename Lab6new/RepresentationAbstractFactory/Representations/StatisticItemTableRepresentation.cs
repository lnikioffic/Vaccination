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
        public string Locality { get { return RepresentEntity.Locality.Locality1; } }

        [DisplayName(@"Количество поставленых вакцин")]
        public string VaccinesCount { get { return RepresentEntity.VaccinesCount.ToString(); } }

        [DisplayName(@"Общая стоимость")]
        public string TotalCost { get { return Math.Round(RepresentEntity.TotalCost, 2).ToString(); } }

        [Browsable(false)]
        public StatisticItem RepresentEntity { get; set; }
        public StatisticItemTableRepresentation(StatisticItem statisticItem) { 
            RepresentEntity = statisticItem;
        }
    }
}
