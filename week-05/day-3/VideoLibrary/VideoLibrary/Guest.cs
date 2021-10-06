using System;

namespace VideoLibrary
{
    public class Guest
    {
        public string GuestName { get; protected set; }
        public string Address { get; protected set; }
        public bool HasVideo { get; protected set; }
        private Video borrowedVideo;

        public Guest(string name, string address)
        {
            GuestName = name;
            Address = address;
        }

        public void Borrow(Video toBorrow)
        {
            this.borrowedVideo = toBorrow;
        }

        public override string ToString()
        {
            if (!HasVideo)
            {
                return $"{GuestName} is currently borrowing the {borrowedVideo}";
            }
            else
            {
                return $"{GuestName} is not borrowing anything at the moment.";
            }
        }

        public Video Steal()
        {
            if (!HasVideo)
            {
                Console.WriteLine("There is no video to steal.");
            }
            return borrowedVideo;
        }
    }
}