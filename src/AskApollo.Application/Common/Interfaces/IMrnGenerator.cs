namespace AskApollo.Application.Common.Interfaces;

public interface IMrnGenerator
{
    Task<string> GenerateAsync(CancellationToken cancellationToken);
}