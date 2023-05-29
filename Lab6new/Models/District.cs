using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new.Models
{
    public partial class District : ICard
    {
        public int Id { get; set; }

        public string District1 { get; set; } = null!;

        public virtual ICollection<Locality> Localities { get; set; } = new List<Locality>();
    }
}
