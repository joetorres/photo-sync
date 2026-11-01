using photo_sync.model.Enums;

namespace photo_sync.model.Entities;

/// <summary>Arquivo na origem. Várias origens podem apontar para a mesma mídia consolidada.</summary>
public class MediaFile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ConnectionId { get; set; }
    /// <summary>Identificador do provedor; para pasta local, caminho relativo à raiz conectada.</summary>
    public string SourceFileId { get; set; } = string.Empty;
    public string? SourcePath { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string? MimeType { get; set; }
    public MediaType MediaType { get; set; }
    public long? SizeBytes { get; set; }
    /// <summary>Data de captura com offset quando conhecido; sem offset, Kind deve ser Unspecified.</summary>
    public DateTime? CapturedAt { get; set; }
    public TimeSpan? CapturedUtcOffset { get; set; }
    public MediaDateSource DateSource { get; set; }
    public DateTimeOffset? SourceCreatedAtUtc { get; set; }
    public DateTimeOffset? SourceModifiedAtUtc { get; set; }
    /// <summary>Versão/ETag para detectar mudanças e invalidar um hash anterior.</summary>
    public string? SourceVersion { get; set; }
    /// <summary>SHA-256 hexadecimal do conteúdo completo. Null enquanto não calculado.</summary>
    public string? ContentHash { get; set; }
    public HashAlgorithmType HashAlgorithm { get; set; } = HashAlgorithmType.Sha256;
    public string? HashedSourceVersion { get; set; }
    public DateTimeOffset? HashComputedAtUtc { get; set; }
    public int? WidthPixels { get; set; }
    public int? HeightPixels { get; set; }
    public TimeSpan? Duration { get; set; }
    public DateTimeOffset FirstDiscoveredAtUtc { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset LastSeenAtUtc { get; set; } = DateTimeOffset.UtcNow;
    public Guid? ConsolidatedMediaId { get; set; }
}
