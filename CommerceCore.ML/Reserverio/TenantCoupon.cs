using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantCoupon
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? DiscountType { get; set; }

    public decimal? DiscountValue { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? UsageLimit { get; set; }

    public int? UsedCount { get; set; }

    public decimal? MinAmount { get; set; }

    public bool? Active { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public bool? Enable { get; set; }

    public int ClassificationId { get; set; }
}
