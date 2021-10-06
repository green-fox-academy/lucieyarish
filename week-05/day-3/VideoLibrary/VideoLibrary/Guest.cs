namespace VideoLibrary
{
    public class Guest
    {
        public string GuestName { get; protected set; }
        public string Address { get; protected set; }
        public bool HasVideo { get; protected set; }

        public Guest(bool hasVideo)
        {
            HasVideo = hasVideo;
        }

        public override string ToString()
        {
            return $"{GuestName} is currently borrowing the AddTitleHERE";
        }
    }
}