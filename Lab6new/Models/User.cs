using System;
using System.Collections.Generic;
using Lab6new.Models.Interface;
using Lab6new.Models;

namespace Lab6new;

public partial class User : IModel
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string Role { get; set; } = null!;

    public int OrganisationId { get; set; }

    public virtual ICollection<Act> Acts { get; set; } = new List<Act>();

    public virtual Organisation Organisation { get; set; } = null!;

    public override string ToString()
    {
        return LastName + " " + FirstName;
    }
}
