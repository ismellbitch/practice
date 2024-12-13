using System;
using System.Collections.Generic;

namespace practice.Models;

public partial class Material
{
    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Picture { get; set; }

    public int Price { get; set; }

    public int Count { get; set; }

    public int MinCount { get; set; }

    public int? ItemsInPackage { get; set; }

    public string? Unit { get; set; }

    public string? Supplier { get; set; }

    public virtual ICollection<Materialsupplier> Materialsuppliers { get; set; } = new List<Materialsupplier>();
}
