using AskApollo.Application.Common.Interfaces;

namespace AskApollo.Infrastructure.Services;

public sealed class MrnGenerator : IMrnGenerator
{
    public Task<string> GenerateAsync(CancellationToken cancellationToken)
    {
        var value = $"IND-{DateTime.UtcNow:MMdd}{Random.Shared.Next(1, 9999):D4}";
        return Task.FromResult(value);
    }
}