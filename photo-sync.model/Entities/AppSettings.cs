using photo_sync.model.Enums;

namespace photo_sync.model.Entities;

public class AppSettings
{
    public int Id { get; set; } = 1;
    public string? LanguageCode { get; set; }
    public ThemePreference Theme { get; set; } = ThemePreference.System;
    public Guid? LastSelectedLibraryId { get; set; }
    public Guid? LastViewedOperationId { get; set; }
    public bool ResumePendingOperationsOnStartup { get; set; } = true;
}
