using System;

namespace CSharpAdvanced
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail sent" + e.Video.Title);
        }
    }
}