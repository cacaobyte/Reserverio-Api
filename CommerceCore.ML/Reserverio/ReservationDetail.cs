using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class ReservationDetail
{
    public int Id { get; set; }

    public int ReservationId { get; set; }

    public int ServiceId { get; set; }

    public int Quantity { get; set; }

    public string? Note { get; set; }
}
