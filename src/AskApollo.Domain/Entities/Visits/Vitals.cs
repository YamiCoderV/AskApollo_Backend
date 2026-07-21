
namespace AskApollo.Domain.Entities.Visits;

public sealed class Vitals
{
    public decimal? TemperatureCelsius { get; init; }

    public int? Pulse { get; init; }

    public string? BloodPressure { get; init; }

    public int? RespiratoryRate { get; init; }

    public decimal? WeightKg { get; init; }

    public decimal? HeightCm { get; init; }

    public int? OxygenSaturation { get; init; }
}
