using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Module
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public string? Icon { get; set; }

    public string? Route { get; set; }

    public int? Order { get; set; }
}
