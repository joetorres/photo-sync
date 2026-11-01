namespace photo_sync.model.Enums;

/// <summary>
/// Valores persistidos: não renumerar nem reutilizar valores existentes.
/// </summary>
public enum ServiceType
{
    Unknown = 0,
    GooglePhotos = 1,
    OneDrive = 2,
    GoogleDrive = 3,
    AppleICloud = 4,
    Dropbox = 5,
    LocalFolder = 6,
}
