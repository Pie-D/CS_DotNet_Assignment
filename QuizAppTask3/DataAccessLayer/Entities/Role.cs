﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities;

public partial class Role
{
    public string Id { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}