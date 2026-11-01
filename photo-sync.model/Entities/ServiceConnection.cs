using photo_sync.model.Enums;

namespace photo_sync.model.Entities;

/// <summary>Uma conta de serviço ou pasta local conectada ao aplicativo.</summary>
public class ServiceConnection
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public ServiceType ServiceType { get; set; }
    public string DisplayName { get; set; } = string.Empty;
    public string? AccountId { get; set; }
    public string? AccountEmail { get; set; }
    public string? LocalFolderPath { get; set; }
    public ConnectionStatus Status { get; set; }
    public DateTimeOffset CreatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? LastScannedAtUtc { get; set; }
}
