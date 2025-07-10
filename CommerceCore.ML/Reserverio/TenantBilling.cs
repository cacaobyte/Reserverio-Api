using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantBilling
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? BillingPlan { get; set; }

    public string? PaymentStatus { get; set; }

    public DateOnly? LastPaymentDate { get; set; }

    public DateOnly? NextPaymentDue { get; set; }

    public DateOnly? TrialEndDate { get; set; }

    public bool? IsOnTrial { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }
}
