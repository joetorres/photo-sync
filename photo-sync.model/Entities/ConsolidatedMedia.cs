using photo_sync.model.Enums;

namespace photo_sync.model.Entities;

/// <summary>Cópia física consolidada, identificada pelo hash dentro de uma biblioteca.</summary>
public class ConsolidatedMedia
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid LibraryId { get; set; }
    public Guid OriginalMediaFileId { get; set; }
    public string RelativePath { get; set; } = string.Empty;
    public string ContentHash { get; set; } = string.Empty;
    public HashAlgorithmType HashAlgorithm { get; set; } = HashAlgorithmType.Sha256;
    public long SizeBytes { get; set; }
    public DateTimeOffset AddedAtUtc { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? LastVerifiedAtUtc { get; set; }
}
