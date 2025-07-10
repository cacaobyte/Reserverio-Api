using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class UsersRole
{
    public int Id { get; set; }

    public int IdUsers { get; set; }

    public int IdRol { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public bool? Enable { get; set; }
}
