using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Reservation
{
    public int Id { get; set; }

    public int PublicUserId { get; set; }

    public int TenantId { get; set; }

    public DateOnly? ReservationDate { get; set; }

    public DateOnly? StartTime { get; set; }

    public DateOnly? EndTime { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public string? Source { get; set; }

    public string? CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }

    public string? CreateBy { get; set; }

    public string UpdateBy { get; set; } = null!;

    public bool? Active { get; set; }
}
