namespace photo_sync.model.Enums;

/// <summary>
/// Valores persistidos: não renumerar nem reutilizar valores existentes.
/// </summary>
public enum OperationStatus
{
    Pending = 0,
    Running = 1,
    Paused = 2,
    Completed = 3,
    CompletedWithErrors = 4,
    Failed = 5,
    Canceled = 6,
}
