using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantClassificationMap
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int ClassId { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdateAt { get; set; }
}
