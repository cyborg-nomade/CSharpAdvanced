using System;
using System.Threading;

namespace CSharpAdvanced
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2 - Define an event based on that delegate
        // 3- Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler
        // EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}