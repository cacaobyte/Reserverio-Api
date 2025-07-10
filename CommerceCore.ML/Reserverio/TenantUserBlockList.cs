using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantUserBlockList
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int PublicUserId { get; set; }

    public string? Reason { get; set; }

    public DateOnly? BlockedAt { get; set; }

    public DateOnly? BlockedUntil { get; set; }

    public int? BlockedDays { get; set; }

    public bool? Enable { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? UpdateBy { get; set; }

    public string? Note { get; set; }
}
