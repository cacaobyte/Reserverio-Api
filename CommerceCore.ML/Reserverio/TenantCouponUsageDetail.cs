using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantCouponUsageDetail
{
    public int Id { get; set; }

    public int UsageLogId { get; set; }

    public int ServiceId { get; set; }

    public decimal OriginalPrice { get; set; }

    public decimal FinalPrice { get; set; }
}
