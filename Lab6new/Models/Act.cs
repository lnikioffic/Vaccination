using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;

namespace Lab6new.Models;

public partial class Act : IModel
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int AnimalId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Type { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;

    public int LocalityId { get; set; }

    public int ContractId { get; set; }

    public virtual Animal Animal { get; set; } = null!;

    public virtual Contract Contract { get; set; } = null!;

    public virtual Locality Locality { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
