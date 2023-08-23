using System.Net;

namespace Moca.BFF.External.ExceptionHandler
{
    public class BusinessException : Exception
    {
        public int StatusCode { get; }
        public DateTime Data { get; set; }


        public BusinessException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = (int)statusCode;
            Data = DateTime.Now;
        }
    }
}
