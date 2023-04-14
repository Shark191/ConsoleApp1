
internal class InvalidName : Exception
{
    public InvalidName()
    {
    }

    public InvalidName(string? message) : base(message)
    {
    }

    public InvalidName(string? message, Exception? innerException) : base(message, innerException)
    {
    }

}