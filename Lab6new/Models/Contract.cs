using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;

namespace Lab6new.Models;

public partial class Contract : ICard
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int OrderOrganisationId { get; set; }

    public int PerformOrganisationId { get; set; }

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();

    public virtual ICollection<Cost> Costs { get; set; } = new List<Cost>();

    public virtual Organisation OrderOrganisation { get; set; } = null!;

    public virtual Organisation PerformOrganisation { get; set; } = null!;

    public override string ToString()
    {
        return Number;
    }
}
