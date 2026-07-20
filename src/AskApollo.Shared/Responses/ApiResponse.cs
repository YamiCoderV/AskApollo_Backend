namespace AskApollo.Shared.Responses;

public class ApiResponse<T>
{
    public bool Success { get; init; }

    public string Message { get; init; } = string.Empty;

    public T? Data { get; init; }

    public List<string> Errors { get; init; } = new();

    public DateTime Timestamp { get; init; }
        = DateTime.UtcNow;

    public static ApiResponse<T> Ok(
        T data,
        string message = "")
    {
        return new ApiResponse<T>
        {
            Success = true,
            Data = data,
            Message = message
        };
    }

    public static ApiResponse<T> Fail(
        params string[] errors)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Errors = errors.ToList()
        };
    }
}
