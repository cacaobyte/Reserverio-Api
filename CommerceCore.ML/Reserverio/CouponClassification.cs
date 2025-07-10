using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class CouponClassification
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Slug { get; set; }

    public string? Description { get; set; }

    public string? IconUrl { get; set; }

    public string? ColorCode { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }
}
