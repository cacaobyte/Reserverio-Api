using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class RoleOperation
{
    public int Id { get; set; }

    public int IdOperacion { get; set; }

    public int IdRol { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }
}
