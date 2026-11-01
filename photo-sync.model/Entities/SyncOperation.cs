using photo_sync.model.Enums;

namespace photo_sync.model.Entities;

/// <summary>Execução persistida de escaneamento, consolidação ou upload.</summary>
public class SyncOperation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public OperationType Type { get; set; }
    public OperationStatus Status { get; set; }
    public List<Guid> SourceConnectionIds { get; set; } = [];
    public Guid? LibraryId { get; set; }
    public Guid? DestinationConnectionId { get; set; }
    /// <summary>Nome solicitado; o provedor pode tratar o destino como álbum ou pasta.</summary>
    public string? DestinationContainerName { get; set; }
    public string? DestinationContainerId { get; set; }
    public DateTimeOffset CreatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? StartedAtUtc { get; set; }
    public DateTimeOffset? FinishedAtUtc { get; set; }
    public DateTimeOffset? LastCheckpointAtUtc { get; set; }
    /// <summary>Cursor opaco do provedor para retomada de um escaneamento.</summary>
    public string? ScanCursor { get; set; }
    public Guid? ScanCursorConnectionId { get; set; }
    public string? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
}
