using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;

namespace Lab6new.Models;

public partial class Locality : ICard
{
    public int Id { get; set; }

    public string Locality1 { get; set; } = null!;

    public int DistrictId { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual ICollection<Cost> Costs { get; set; } = new List<Cost>();

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();

    public override string ToString()
    {
        return Locality1;
    }
}
