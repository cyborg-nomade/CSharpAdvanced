using System;

namespace CSharpAdvanced
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<>
            //System.Func<>
            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filterHandler(photo);

            photo.Save();
        }
    }
}