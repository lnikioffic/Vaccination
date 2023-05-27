﻿using Lab6new.Models.Interface;
using System;
using System.Collections.Generic;

namespace Lab6new.Models;

public partial class Cost : ICard
{
    public int Id { get; set; }

    public int ContractId { get; set; }

    public int LocalityId { get; set; }

    public double Cost1 { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual Locality Locality { get; set; } = null!;
}
