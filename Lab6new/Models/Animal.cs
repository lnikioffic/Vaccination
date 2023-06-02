using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;

namespace Lab6new.Models;

public partial class Animal : ICard
{
    public int Id { get; set; }

    public string RegistrationNumber { get; set; } = null!;

    public bool Category { get; set; }

    public bool Sex { get; set; }

    public int BirthYear { get; set; }

    public string ChipNumber { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string SpecialSigns { get; set; } = null!;

    public string Photo { get; set; } = null!;

    public int LocalityId { get; set; }

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();

    public virtual Locality Locality { get; set; } = null!;

    public override string ToString()
    {
        return Name;
    }
}
