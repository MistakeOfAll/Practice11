using System;
using System.Collections.Generic;

namespace PraktikaFurniture.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public string? Unit { get; set; }

    public int StockQuantity { get; set; }
}
