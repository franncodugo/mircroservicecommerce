namespace MCCommerce.Services.CouponAPI.Common;

/// <summary>
/// Success - creates a success result
/// Failure - creates a failure result with the specified Error
/// </summary>
public sealed class Result
{
    private Result(bool isSucess, Error error)
    {
        if (isSucess && error != Error.None ||
            !isSucess && error == Error.None)
        {
            throw new ArgumentException("Invalid Error", nameof(error));
        }

        IsSuccess = isSucess;
        Error = error;
    }
    
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
    public static Result Success() => new(true, Common.Error.None);
    public static Result Failure(Error error) => new(false, error);
}