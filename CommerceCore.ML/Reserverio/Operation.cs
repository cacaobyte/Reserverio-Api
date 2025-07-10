using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Operation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int IdModulo { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public bool? Active { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public int? Order { get; set; }
}
