using System;
using System.Collections.Generic;

namespace Reserverio.DAL.Commerce.Models.Reserverio;

public partial class Plan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public int? Maxtenantsallowed { get; set; }

    public int? Maxuserspertenant { get; set; }

    public int? Maxmainuserspertenant { get; set; }

    public int? Maxservices { get; set; }

    public int? Maxbookingspermonth { get; set; }

    public int? Maxstoragemb { get; set; }

    public bool? Istrial { get; set; }

    public DateOnly? Trialstartdate { get; set; }

    public DateOnly? Trialenddate { get; set; }

    public bool? Isactive { get; set; }

    public DateOnly? Createdat { get; set; }

    public DateOnly? Updatedat { get; set; }

    public virtual ICollection<Plansetting> Plansettings { get; set; } = new List<Plansetting>();
}
