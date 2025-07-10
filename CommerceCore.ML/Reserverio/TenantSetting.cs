using System;
using System.Collections.Generic;

namespace ReserverioCore.ML.Reserverio;

/// <summary>
/// Tabla de configuraciones del Tenant del negocio para poder aplicar asi las reglas del negocio del sistema y asi mismo a los usuarios los cuales han interactuado con este tenant
/// </summary>
public partial class TenantSetting
{
    public int Id { get; set; }

    public int TenantSettings { get; set; }

    /// <summary>
    /// Sirve para validar si se permite una reservación doble por día
    /// </summary>
    public bool AllowDoubleBooking { get; set; }

    public bool? EnableWhatsappNotifications { get; set; }

    public int? BookingWindowDays { get; set; }

    public string? CustomTheme { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public DateOnly? UpdatedAt { get; set; }

    public bool? SendNotification { get; set; }

    public bool? AllowBookingOutsideSchedule { get; set; }

    /// <summary>
    /// Limita cuántas reservas puede hacer un usuario por día
    /// </summary>
    public int? MaxDailyBookingsPerUser { get; set; }

    /// <summary>
    /// Define cuántas horas antes debe reservar (ej: 2h de anticipación mínima)
    /// </summary>
    public int? MinHoursBeforeBooking { get; set; }

    /// <summary>
    /// Si las reservas deben aprobarse manualmente o entran directas
    /// </summary>
    public bool? AutoApproveReservations { get; set; }

    /// <summary>
    /// Si se activan mensajes SMS (por plan Premium, por ejemplo)
    /// </summary>
    public bool? EnableSmsnotifications { get; set; }

    /// <summary>
    /// Cuántas horas antes se puede cancelar una reserva
    /// </summary>
    public int? CancelationTimeLimitHours { get; set; }

    /// <summary>
    /// Si una reserva puede tener más de un servicio seleccionado
    /// </summary>
    public bool? AllowMultipleServicesPerBooking { get; set; }

    /// <summary>
    /// Permitir reprogramar reservas sin cancelar
    /// </summary>
    public bool? EnableReschedule { get; set; }

    /// <summary>
    /// Duración estándar del bloque (ej: 30 minutos, 60, etc.)
    /// </summary>
    public int? BookingSlotDurationMinutes { get; set; }

    /// <summary>
    /// Bloquea correos que han sido baneados previamente
    /// </summary>
    public bool? BlockBlacklistedEmails { get; set; }

    /// <summary>
    /// Solo muestra horarios disponibles (sin mostrar todos los bloques)
    /// </summary>
    public bool? ShowAvailableSlotsOnly { get; set; }
}
