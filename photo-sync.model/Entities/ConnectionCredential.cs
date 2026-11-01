namespace photo_sync.model.Entities;

/// <summary>Referência ao segredo guardado no cofre do sistema; não contém tokens em texto puro.</summary>
public class ConnectionCredential
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ConnectionId { get; set; }
    public string SecretStoreKey { get; set; } = string.Empty;
    public string? GrantedScopes { get; set; }
    public DateTimeOffset? AccessTokenExpiresAtUtc { get; set; }
    public DateTimeOffset UpdatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
}
