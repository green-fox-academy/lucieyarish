using System;
using System.IO;

namespace VideoLibrary
{
    public class Video
    {
        public string Title { get; protected set; }
        public string Director { get; protected set; }
        public int ReleaseYear { get; protected set; }
        public int Price { get; protected set; }
        public int BorrowedTimes { get; protected set; }
        public bool IsBorrowedNow { get; protected set; }
        private VideoType Type;

        public Video()
        {
            
        }
        
        public Video(VideoType type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"{Title} by {Director} from {ReleaseYear} - borrowed {BorrowedTimes} times.";
        }

        public Colored Copy()
        {
            try
            {
                if (Type == VideoType.Colored)
                {
                    return new Colored();
                }
            }
            catch (Exception)
            {
                throw new Exception("The police will find you soon.");
            }
            return new Colored();
        }
    }
}