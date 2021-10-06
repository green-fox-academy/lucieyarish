using System.Collections.Generic;

namespace VideoLibrary
{
    public class VideoStore
    {
        public List<Guest> Guests { get; protected set; }
        public List<Video> Videos { get; protected set; }

        public VideoStore()
        {
            Guests = new List<Guest>();
            Videos = new List<Video>();
        }

        public void AddGuest(Guest guest)
        {
            Guests.Add(guest);
        }

        public void AddVideo(Video video)
        {
            Videos.Add(video);
        }

        public void Borrow(Guest guest, Video video)
        {
            if (!(guest.HasVideo))
            {
                
            }
        }
        
    }
}