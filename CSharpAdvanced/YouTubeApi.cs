using System;
using System.Collections.Generic;

namespace CSharpAdvanced
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube web service
                // Read the data
                // Create a list of video objects
                throw new Exception("Oops some low level YouTube error");
            }
            catch (Exception e)
            {
                // Log


                throw new YouTubeException("Could not fetch the YouTube videos", e);
            }

            return new List<Video>();
        }
    }
}