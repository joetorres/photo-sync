namespace photo_sync.model.Enums;

/// <summary>
/// Valores persistidos: não renumerar nem reutilizar valores existentes.
/// </summary>
public enum MediaDateSource
{
    Unknown = 0,
    EmbeddedMetadata = 1,
    ProviderMetadata = 2,
    FileCreationTime = 3,
    FileLastWriteTime = 4,
}
