﻿using System;
using System.Collections.Generic;

namespace AirConditionerShop.DAL.Entities;

public partial class AirConditioner
{
    public int AirConditionerId { get; set; }

    public string AirConditionerName { get; set; } = null!;

    public string? Warranty { get; set; }

    public string? SoundPressureLevel { get; set; }

    public string? FeatureFunction { get; set; }

    public int? Quantity { get; set; }

    public double? DollarPrice { get; set; }

    public string? SupplierId { get; set; }

    public virtual SupplierCompany? Supplier { get; set; } // OOP: object Máy lạnh này tham chiếu dến Nhà Cung Cấp tương ứng
    // supplier này là biến trỏ vào vùng new SUpplierCompany (1 dòng trong Supplier)
}
