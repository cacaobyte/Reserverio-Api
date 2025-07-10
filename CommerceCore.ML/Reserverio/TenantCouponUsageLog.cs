using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantCouponUsageLog
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public int PublicUserId { get; set; }

    public int TenantId { get; set; }

    public int ReservationId { get; set; }

    public DateOnly? UsedAt { get; set; }

    public decimal? DiscountApplied { get; set; }
}
