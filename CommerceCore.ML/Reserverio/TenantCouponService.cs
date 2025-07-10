using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantCouponService
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public int ServiceId { get; set; }

    public DateOnly? CreatedAt { get; set; }
}
