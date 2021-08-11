using System;

namespace CSharpAdvanced
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message sent" + args.Video.Title);
        }
    }
}