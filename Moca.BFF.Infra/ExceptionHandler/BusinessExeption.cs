namespace Moca.BFF.External.ExceptionHandler
{
    public class BusinessException : Exception
    {
        public int StatusCode { get; }

        public BusinessException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
