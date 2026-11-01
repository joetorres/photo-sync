namespace photo_sync.model.Enums;

/// <summary>
/// Valores persistidos: não renumerar nem reutilizar valores existentes.
/// </summary>
public enum SyncItemStatus
{
    Pending = 0,
    InProgress = 1,
    Succeeded = 2,
    SkippedDuplicate = 3,
    Failed = 4,
    Canceled = 5,
}
