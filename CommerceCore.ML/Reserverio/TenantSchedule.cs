using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

public partial class TenantSchedule
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int IdSetting { get; set; }

    public int? DayOfWeek { get; set; }

    public string? DayName { get; set; }

    public bool? IsWorkingDay { get; set; }

    public DateOnly? OpenTime { get; set; }

    public DateOnly? CloseTime { get; set; }

    public DateOnly? BreakStartTime { get; set; }

    public DateOnly? BreakEndTime { get; set; }

    public bool? AllowBookingDuringBreak { get; set; }

    public bool? MultipleShifts { get; set; }

    public DateOnly? OpenTimeShift2 { get; set; }

    public DateOnly? CloseTimeShift2 { get; set; }

    public string? ScheduleType { get; set; }

    public int? ScheduleOrder { get; set; }

    public string? Notes { get; set; }

    public bool? VisibleOnCalendar { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }

    public bool? Active { get; set; }
}
