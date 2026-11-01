namespace photo_sync.model.Enums;

/// <summary>
/// Valores persistidos: não renumerar nem reutilizar valores existentes.
/// </summary>
public enum ConnectionStatus
{
    NotConnected = 0,
    Connected = 1,
    AuthenticationRequired = 2,
    Unavailable = 3,
}
