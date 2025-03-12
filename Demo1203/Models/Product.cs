using System;
using System.Collections.Generic;

namespace Demo1203.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int MeasureUnit { get; set; }

    public decimal Cost { get; set; }

    public decimal MaxDiscount { get; set; }

    public int Manufacturer { get; set; }

    public int Supplier { get; set; }

    public int Category { get; set; }

    public decimal? Discount { get; set; }

    public int QuantityInStock { get; set; }

    public string? Description { get; set; }

    public string? PhotoPath { get; set; }

    public virtual Category CategoryNavigation { get; set; } = null!;

    public virtual Manufacturer ManufacturerNavigation { get; set; } = null!;

    public virtual MeasureUnit MeasureUnitNavigation { get; set; } = null!;

    public virtual Supplier SupplierNavigation { get; set; } = null!;
}
