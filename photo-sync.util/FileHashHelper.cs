using System.Security.Cryptography;

namespace photo_sync.util;

/// <summary>Calcula SHA-256 do conteúdo completo, retornando 64 caracteres hexadecimais minúsculos.</summary>
public static class FileHashHelper
{
    /// <summary>Lê o arquivo sem carregá-lo inteiro em memória e fecha o stream ao terminar.</summary>
    public static async Task<string> ComputeSha256Async(
        string filePath,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        await using var stream = new FileStream(filePath, new FileStreamOptions
        {
            Mode = FileMode.Open,
            Access = FileAccess.Read,
            Share = FileShare.Read,
            Options = FileOptions.Asynchronous | FileOptions.SequentialScan,
        });

        return await ComputeSha256Async(stream, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Lê da posição atual até o final, sem fechar nem reposicionar o stream.
    /// Para obter o hash do arquivo inteiro, forneça o stream no início do conteúdo.
    /// </summary>
    public static async Task<string> ComputeSha256Async(
        Stream stream,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(stream);
        if (!stream.CanRead)
        {
            throw new ArgumentException("O stream deve permitir leitura.", nameof(stream));
        }

        var hash = await SHA256.HashDataAsync(stream, cancellationToken).ConfigureAwait(false);
        return Convert.ToHexStringLower(hash);
    }
}
