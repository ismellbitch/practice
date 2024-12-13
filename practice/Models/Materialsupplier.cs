using System;
using System.Collections.Generic;

namespace practice.Models;

public partial class Materialsupplier
{
    public int Id { get; set; }

    public string Material { get; set; } = null!;

    public string Supplier { get; set; } = null!;

    public virtual Material MaterialNavigation { get; set; } = null!;

    public virtual Supplier SupplierNavigation { get; set; } = null!;
}
