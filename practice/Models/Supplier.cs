using System;
using System.Collections.Generic;

namespace practice.Models;

public partial class Supplier
{
    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public int Rating { get; set; }

    public DateOnly WorkSince { get; set; }

    public virtual ICollection<Materialsupplier> Materialsuppliers { get; set; } = new List<Materialsupplier>();
}
