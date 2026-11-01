namespace photo_sync.model.Reports;

/// <summary>Resumo calculado a partir dos itens persistidos de uma operação.</summary>
public class SyncReport
{
    public Guid OperationId { get; set; }
    public long TotalFiles { get; set; }
    public long PendingFiles { get; set; }
    public long InProgressFiles { get; set; }
    public long SucceededFiles { get; set; }
    public long DuplicateFiles { get; set; }
    public long FailedFiles { get; set; }
    public long CanceledFiles { get; set; }
    public long BytesTransferred { get; set; }
    public DateTimeOffset GeneratedAtUtc { get; set; } = DateTimeOffset.UtcNow;
}
