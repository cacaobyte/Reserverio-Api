using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class ReservationLog
{
    public int Id { get; set; }

    public int ReservationId { get; set; }

    public string? Action { get; set; }

    public string? PerformedBy { get; set; }

    public DateOnly? Timestamp { get; set; }

    public string? Notes { get; set; }
}
