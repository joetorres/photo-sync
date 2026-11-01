using System.Globalization;

namespace photo_sync.util;

/// <summary>
/// Formata datas sem alterar o fuso horário. A conversão de UTC para o horário desejado
/// deve ser feita pelo chamador antes da formatação.
/// </summary>
public static class DateFormatHelper
{
    /// <summary>Nome de pasta estável, independente da cultura: AAAA-MM.</summary>
    public static string ToYearMonthFolder(DateTime date) =>
        date.ToString("yyyy-MM", CultureInfo.InvariantCulture);

    /// <summary>Usa o ano e mês do offset informado, sem converter para UTC.</summary>
    public static string ToYearMonthFolder(DateTimeOffset date) =>
        date.ToString("yyyy-MM", CultureInfo.InvariantCulture);

    public static string ToYearMonthFolder(DateOnly date) =>
        date.ToString("yyyy-MM", CultureInfo.InvariantCulture);

    /// <summary>Data curta na cultura informada ou na cultura atual da interface.</summary>
    public static string ToDisplayDate(DateTime date, CultureInfo? culture = null) =>
        date.ToString("d", culture ?? CultureInfo.CurrentCulture);

    public static string ToDisplayDate(DateTimeOffset date, CultureInfo? culture = null) =>
        date.ToString("d", culture ?? CultureInfo.CurrentCulture);

    public static string ToDisplayDate(DateOnly date, CultureInfo? culture = null) =>
        date.ToString("d", culture ?? CultureInfo.CurrentCulture);

    /// <summary>Data curta e horário com segundos na cultura informada ou na cultura atual.</summary>
    public static string ToDisplayDateTime(DateTime date, CultureInfo? culture = null) =>
        date.ToString("G", culture ?? CultureInfo.CurrentCulture);

    public static string ToDisplayDateTime(DateTimeOffset date, CultureInfo? culture = null) =>
        date.ToString("G", culture ?? CultureInfo.CurrentCulture);
}
