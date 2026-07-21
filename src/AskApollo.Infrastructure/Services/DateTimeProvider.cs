using AskApollo.Application.Common.Interfaces;

namespace AskApollo.Infrastructure.Services;

public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}