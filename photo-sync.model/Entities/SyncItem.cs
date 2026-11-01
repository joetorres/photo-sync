using photo_sync.model.Enums;

namespace photo_sync.model.Entities;

/// <summary>Resultado e checkpoint de um arquivo em uma operação.</summary>
public class SyncItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid OperationId { get; set; }
    public Guid MediaFileId { get; set; }
    public SyncItemStatus Status { get; set; }
    public Guid? ConsolidatedMediaId { get; set; }
    /// <summary>Arquivo correspondente quando o item é ignorado por duplicidade exata.</summary>
    public Guid? DuplicateOfMediaFileId { get; set; }
    public string? DestinationPath { get; set; }
    public string? DestinationFileId { get; set; }
    public long BytesTransferred { get; set; }
    public int AttemptCount { get; set; }
    public string? TemporaryFilePath { get; set; }
    /// <summary>Referência segura para estado de transferência; não persistir URLs com tokens aqui.</summary>
    public string? ResumeStateSecretStoreKey { get; set; }
    public DateTimeOffset? StartedAtUtc { get; set; }
    public DateTimeOffset? FinishedAtUtc { get; set; }
    public DateTimeOffset UpdatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
    public string? ErrorCode { get; set; }
    public string? ErrorMessage { get; set; }
}
