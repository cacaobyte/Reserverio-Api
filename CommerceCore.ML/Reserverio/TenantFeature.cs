using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantFeature
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? FeatureCode { get; set; }

    public bool? IsEnabled { get; set; }

    public DateOnly? EnabledAt { get; set; }

    public DateOnly? UpdateAt { get; set; }
}
