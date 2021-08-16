using System;

namespace CSharpAdvanced
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}