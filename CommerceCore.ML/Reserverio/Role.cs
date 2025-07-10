using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class Role
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public bool Active { get; set; }
}
