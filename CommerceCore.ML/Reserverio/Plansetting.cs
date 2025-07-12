using System;
using System.Collections.Generic;

namespace Reserverio.DAL.Commerce.Models.Reserverio;

public partial class Plansetting
{
    public int Id { get; set; }

    public int Planid { get; set; }

    public string? Modulename { get; set; }

    public string? Featurekey { get; set; }

    public string? Featurevalue { get; set; }

    public int? Limitperfeature { get; set; }

    public bool? Isvisible { get; set; }

    public bool? Iscustomizable { get; set; }

    public string? Featuretype { get; set; }

    public string? Notes { get; set; }

    public DateOnly? Createdat { get; set; }

    public DateOnly? Updatedat { get; set; }

    public virtual Plan Plan { get; set; } = null!;
}
