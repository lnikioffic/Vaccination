using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Models
{
    internal class StatisticItem
    {

        public Locality Locality { get; set; } = null!;

        public int VaccinesCount {get; set;}

        public double TotalCost { get; set; }   

    }
}
