using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;

namespace Lab6new.Models;

public partial class Organisation : ICard
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string Kpp { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool Entity { get; set; }

    public int LocalityId { get; set; }

    public virtual ICollection<Contract> ContractOrderOrganisations { get; set; } = new List<Contract>();

    public virtual ICollection<Contract> ContractPerformOrganisations { get; set; } = new List<Contract>();

    public virtual Locality Locality { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
